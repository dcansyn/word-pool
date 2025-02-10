using CefSharp;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPool.UI.Api;
using WordPool.UI.Extensions;
using WordPool.UI.Settings;

namespace WordPool.UI.Events
{
    public static class BrowserEvents
    {
        public static async void OnDeepLResourceLoadComplete(this FormMain form, string result, IRequest request, IResponse response)
        {
            if (form._browserDeepL._browser.IsLoading) return;
            if (!form._browserDeepL._browser.CanExecuteJavascriptInMainFrame) return;

            if (request.Url.Contains("deepl") && request.Url.Contains("LMT_handle_jobs"))
            {
                foreach (var code in DeepLSettings.Codes)
                    form._browserDeepL._browser.CallFunction(code);

                form.InvokeControl(async () =>
                {
                    form.TabControl.SelectedIndex = 1;

                    if (form.ChkBoxDeepLIsShow.Checked)
                        await form.GoTop();
                });

                var translatedValue = await form._browserDeepL._browser.GetElementValue("d-textarea[lang=tr-TR]");
                if (string.IsNullOrEmpty(translatedValue.Result.ToString())) return;

                if (form.ChkBoxDeepLIsCopy.Checked)
                {
                    var copyThread = new Thread(() => Clipboard.SetText(translatedValue.Result.ToString()));
                    copyThread.SetApartmentState(ApartmentState.STA);
                    copyThread.Start();
                    copyThread.Join();

                    var toast = new ToastContentBuilder();
                    toast.AddArgument("deepl").AddText("Text Translated & Copied").AddText("Please click for detail!").Show();
                }
            }
        }
    }
}
