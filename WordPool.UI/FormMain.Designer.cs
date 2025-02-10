namespace WordPool.UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SchedulerTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabGoogle = new System.Windows.Forms.TabPage();
            this.WordListView = new System.Windows.Forms.ListView();
            this.EnglishColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurkishColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelReminderMinutes = new System.Windows.Forms.Label();
            this.ComboBoxTimerInterval = new System.Windows.Forms.ComboBox();
            this.GroupBoxGoogle = new System.Windows.Forms.GroupBox();
            this.TabDeepL = new System.Windows.Forms.TabPage();
            this.GroupBoxDeepL = new System.Windows.Forms.GroupBox();
            this.ChkBoxGoogleTranslatorIsActive = new System.Windows.Forms.CheckBox();
            this.ChkBoxDeepLIsActive = new System.Windows.Forms.CheckBox();
            this.ChkBoxDeepLIsShow = new System.Windows.Forms.CheckBox();
            this.ChkBoxDeepLIsCopy = new System.Windows.Forms.CheckBox();
            this.TabControl.SuspendLayout();
            this.TabGoogle.SuspendLayout();
            this.TabDeepL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SchedulerTimer
            // 
            this.SchedulerTimer.Enabled = true;
            this.SchedulerTimer.Interval = 60000;
            this.SchedulerTimer.Tick += new System.EventHandler(this.SchedulerTimer_Tick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabGoogle);
            this.TabControl.Controls.Add(this.TabDeepL);
            this.TabControl.Location = new System.Drawing.Point(12, 35);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1216, 682);
            this.TabControl.TabIndex = 9;
            // 
            // TabGoogle
            // 
            this.TabGoogle.Controls.Add(this.WordListView);
            this.TabGoogle.Controls.Add(this.LabelReminderMinutes);
            this.TabGoogle.Controls.Add(this.ComboBoxTimerInterval);
            this.TabGoogle.Controls.Add(this.GroupBoxGoogle);
            this.TabGoogle.Location = new System.Drawing.Point(4, 22);
            this.TabGoogle.Name = "TabGoogle";
            this.TabGoogle.Padding = new System.Windows.Forms.Padding(3);
            this.TabGoogle.Size = new System.Drawing.Size(1208, 656);
            this.TabGoogle.TabIndex = 0;
            this.TabGoogle.Text = "Google Translator";
            this.TabGoogle.UseVisualStyleBackColor = true;
            // 
            // WordListView
            // 
            this.WordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnglishColumn,
            this.TurkishColumn});
            this.WordListView.FullRowSelect = true;
            this.WordListView.GridLines = true;
            this.WordListView.HideSelection = false;
            this.WordListView.Location = new System.Drawing.Point(611, 37);
            this.WordListView.MultiSelect = false;
            this.WordListView.Name = "WordListView";
            this.WordListView.Size = new System.Drawing.Size(591, 636);
            this.WordListView.TabIndex = 12;
            this.WordListView.UseCompatibleStateImageBehavior = false;
            this.WordListView.View = System.Windows.Forms.View.Details;
            this.WordListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WordListView_MouseDoubleClick);
            // 
            // EnglishColumn
            // 
            this.EnglishColumn.Text = "English";
            this.EnglishColumn.Width = 280;
            // 
            // TurkishColumn
            // 
            this.TurkishColumn.Text = "Turkish";
            this.TurkishColumn.Width = 280;
            // 
            // LabelReminderMinutes
            // 
            this.LabelReminderMinutes.AutoSize = true;
            this.LabelReminderMinutes.Location = new System.Drawing.Point(611, 13);
            this.LabelReminderMinutes.Name = "LabelReminderMinutes";
            this.LabelReminderMinutes.Size = new System.Drawing.Size(98, 13);
            this.LabelReminderMinutes.TabIndex = 10;
            this.LabelReminderMinutes.Text = "Reminder Minutes :";
            // 
            // ComboBoxTimerInterval
            // 
            this.ComboBoxTimerInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTimerInterval.FormattingEnabled = true;
            this.ComboBoxTimerInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxTimerInterval.Location = new System.Drawing.Point(709, 10);
            this.ComboBoxTimerInterval.Name = "ComboBoxTimerInterval";
            this.ComboBoxTimerInterval.Size = new System.Drawing.Size(132, 21);
            this.ComboBoxTimerInterval.TabIndex = 9;
            this.ComboBoxTimerInterval.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTimerInterval_SelectedIndexChanged);
            // 
            // GroupBoxGoogle
            // 
            this.GroupBoxGoogle.Location = new System.Drawing.Point(6, 6);
            this.GroupBoxGoogle.Name = "GroupBoxGoogle";
            this.GroupBoxGoogle.Size = new System.Drawing.Size(599, 667);
            this.GroupBoxGoogle.TabIndex = 3;
            this.GroupBoxGoogle.TabStop = false;
            this.GroupBoxGoogle.Text = "Google Web Browser";
            // 
            // TabDeepL
            // 
            this.TabDeepL.Controls.Add(this.GroupBoxDeepL);
            this.TabDeepL.Location = new System.Drawing.Point(4, 22);
            this.TabDeepL.Name = "TabDeepL";
            this.TabDeepL.Padding = new System.Windows.Forms.Padding(3);
            this.TabDeepL.Size = new System.Drawing.Size(1208, 656);
            this.TabDeepL.TabIndex = 1;
            this.TabDeepL.Text = "DeepL Translator";
            this.TabDeepL.UseVisualStyleBackColor = true;
            // 
            // GroupBoxDeepL
            // 
            this.GroupBoxDeepL.Location = new System.Drawing.Point(6, 6);
            this.GroupBoxDeepL.Name = "GroupBoxDeepL";
            this.GroupBoxDeepL.Size = new System.Drawing.Size(1196, 667);
            this.GroupBoxDeepL.TabIndex = 4;
            this.GroupBoxDeepL.TabStop = false;
            this.GroupBoxDeepL.Text = "DeepL Web Browser (CTRL + C)";
            // 
            // ChkBoxGoogleTranslatorIsActive
            // 
            this.ChkBoxGoogleTranslatorIsActive.AutoSize = true;
            this.ChkBoxGoogleTranslatorIsActive.Location = new System.Drawing.Point(12, 12);
            this.ChkBoxGoogleTranslatorIsActive.Name = "ChkBoxGoogleTranslatorIsActive";
            this.ChkBoxGoogleTranslatorIsActive.Size = new System.Drawing.Size(104, 17);
            this.ChkBoxGoogleTranslatorIsActive.TabIndex = 10;
            this.ChkBoxGoogleTranslatorIsActive.Text = "Google Is Active";
            this.ChkBoxGoogleTranslatorIsActive.UseVisualStyleBackColor = true;
            // 
            // ChkBoxDeepLIsActive
            // 
            this.ChkBoxDeepLIsActive.AutoSize = true;
            this.ChkBoxDeepLIsActive.Location = new System.Drawing.Point(122, 12);
            this.ChkBoxDeepLIsActive.Name = "ChkBoxDeepLIsActive";
            this.ChkBoxDeepLIsActive.Size = new System.Drawing.Size(102, 17);
            this.ChkBoxDeepLIsActive.TabIndex = 11;
            this.ChkBoxDeepLIsActive.Text = "DeepL Is Active";
            this.ChkBoxDeepLIsActive.UseVisualStyleBackColor = true;
            // 
            // ChkBoxDeepLIsShow
            // 
            this.ChkBoxDeepLIsShow.AutoSize = true;
            this.ChkBoxDeepLIsShow.Location = new System.Drawing.Point(230, 12);
            this.ChkBoxDeepLIsShow.Name = "ChkBoxDeepLIsShow";
            this.ChkBoxDeepLIsShow.Size = new System.Drawing.Size(136, 17);
            this.ChkBoxDeepLIsShow.TabIndex = 13;
            this.ChkBoxDeepLIsShow.Text = "DeepL Is Show on Top";
            this.ChkBoxDeepLIsShow.UseVisualStyleBackColor = true;
            // 
            // ChkBoxDeepLIsCopy
            // 
            this.ChkBoxDeepLIsCopy.AutoSize = true;
            this.ChkBoxDeepLIsCopy.Location = new System.Drawing.Point(372, 12);
            this.ChkBoxDeepLIsCopy.Name = "ChkBoxDeepLIsCopy";
            this.ChkBoxDeepLIsCopy.Size = new System.Drawing.Size(168, 17);
            this.ChkBoxDeepLIsCopy.TabIndex = 14;
            this.ChkBoxDeepLIsCopy.Text = "DeepL Is Copy After Translate";
            this.ChkBoxDeepLIsCopy.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 729);
            this.Controls.Add(this.ChkBoxDeepLIsCopy);
            this.Controls.Add(this.ChkBoxDeepLIsShow);
            this.Controls.Add(this.ChkBoxDeepLIsActive);
            this.Controls.Add(this.ChkBoxGoogleTranslatorIsActive);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Word Pool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabControl.ResumeLayout(false);
            this.TabGoogle.ResumeLayout(false);
            this.TabGoogle.PerformLayout();
            this.TabDeepL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer SchedulerTimer;
        private System.Windows.Forms.TabPage TabGoogle;
        private System.Windows.Forms.ListView WordListView;
        private System.Windows.Forms.ColumnHeader EnglishColumn;
        private System.Windows.Forms.ColumnHeader TurkishColumn;
        private System.Windows.Forms.Label LabelReminderMinutes;
        private System.Windows.Forms.ComboBox ComboBoxTimerInterval;
        private System.Windows.Forms.GroupBox GroupBoxGoogle;
        private System.Windows.Forms.TabPage TabDeepL;
        private System.Windows.Forms.GroupBox GroupBoxDeepL;
        public System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.CheckBox ChkBoxGoogleTranslatorIsActive;
        public System.Windows.Forms.CheckBox ChkBoxDeepLIsActive;
        public System.Windows.Forms.CheckBox ChkBoxDeepLIsShow;
        public System.Windows.Forms.CheckBox ChkBoxDeepLIsCopy;
    }
}

