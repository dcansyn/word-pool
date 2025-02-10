using AutoIt;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPool.UI.Api;
using WordPool.UI.Browsers;
using WordPool.UI.Events;
using WordPool.UI.Extensions;

namespace WordPool.UI
{
    public partial class FormMain : Form
    {
        public readonly WordBrowser _browserGoogle = null;
        public readonly WordBrowser _browserDeepL = null;
        private readonly DataTable _table = null;

        private int googleRow = 0;
        private string previousMouseCoordinate;
        private string clipboard;
        private int googleTimer = 0;
        private DateTime deepLTimer = DateTime.Now;

        public FormMain()
        {
            InitializeComponent();

            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"%USERPROFILE%\Desktop"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _table = openFileDialog.FileName.ConvertExcelToDataTable();

                    foreach (DataRow row in _table.Rows)
                        WordListView.Items.Add(new ListViewItem(new[] { row[0].ToString(), row[1].ToString() }));
                }
                catch (Exception)
                {
                    ThrowFileError();
                    return;
                }
            }
            else
            {
                ThrowFileError();
                return;
            }

            _browserGoogle = new WordBrowser(GroupBoxGoogle);
            _browserGoogle.Navigate("https://translate.google.com");

            _browserDeepL = new WordBrowser(GroupBoxDeepL, this.OnDeepLResourceLoadComplete);
            _browserDeepL.Navigate("https://www.deepl.com/translator");

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                this.InvokeControl(async () =>
                {
                    TabControl.SelectedIndex = 0;

                    await GoTop();

                    ToastNotificationManagerCompat.History.Clear();
                });
            };

            ComboBoxTimerInterval.SelectedIndex = 0;
            TabControl.SelectedIndex = 1;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await GoTop();
        }

        private void ThrowFileError()
        {
            MessageBox.Show("Please select a valid file.", "Word Pool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        public async Task GoTop(int delay = 1000)
        {
            await Task.Delay(delay);

            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
            WindowsApi.SetForegroundWindow(this.Handle);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            googleTimer++;

            var currentMouseCoordinate = $"{MousePosition.X}-{MousePosition.Y}";
            if (currentMouseCoordinate != previousMouseCoordinate)
            {
                previousMouseCoordinate = currentMouseCoordinate;
                googleTimer = 0;
            }

            if (ChkBoxDeepLIsActive.Checked && DateTime.Now > deepLTimer)
            {
                var clipboardText = Clipboard.GetText();
                if (clipboardText != clipboard)
                {
                    deepLTimer = DateTime.Now.AddSeconds(1);
                    clipboard = clipboardText;
                    _browserDeepL.TranslateDeepL(clipboard);
                }
            }
        }

        private void SchedulerTimer_Tick(object sender, EventArgs e)
        {
            if (ChkBoxGoogleTranslatorIsActive.Checked)
            {
                if (googleTimer > 200) return;

                if (WordListView.Items.Count <= 0)
                    return;
                else if (googleRow >= WordListView.Items.Count)
                    googleRow = 0;

                WordListView.Items[googleRow].Focused = true;
                WordListView.Items[googleRow].Selected = true;
                WordListView.Items[googleRow].EnsureVisible();

                var english = WordListView.Items[googleRow].SubItems[0].Text;
                var turkish = WordListView.Items[googleRow].SubItems[1].Text;

                var toast = new ToastContentBuilder();
                toast.AddArgument("google").AddText(english).AddText(turkish).Show();

                _browserGoogle.TranslateGoogle(english);

                googleRow++;
            }
        }

        private void ComboBoxTimerInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ComboBoxTimerInterval.Text, out int interval))
                interval = 1;

            SchedulerTimer.Interval = interval * 60000;
        }

        private void WordListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            googleRow = WordListView.SelectedIndices[0];
        }
    }
}
