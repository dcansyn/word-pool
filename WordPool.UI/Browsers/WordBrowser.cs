using CefSharp;
using CefSharp.WinForms;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WordPool.UI.Handlers;

namespace WordPool.UI.Browsers
{
    public class WordBrowser
    {
        public Action<string, IRequest, IResponse> _eventHandler = null;
        public ChromiumWebBrowser _browser = new ChromiumWebBrowser("about:blank");
        public readonly GroupBox _box;

        public WordBrowser(GroupBox box)
        {
            _box = box;
        }

        public WordBrowser(GroupBox box, Action<string, IRequest, IResponse> eventHandler)
        {
            _eventHandler = eventHandler;
            _box = box;
        }

        public void Navigate(string url)
        {
            _browser = new ChromiumWebBrowser(url)
            {
                RequestHandler = new PoolRequestHandler(_eventHandler),
                Dock = DockStyle.Fill
            };

            _box.Controls.Add(_browser);
        }

        public void TranslateGoogle(string text)
        {
            var url = $"https://translate.google.com/" +
                $"?sl=en" +
                $"&tl=tr" +
                $"&text={text.Replace(Environment.NewLine, "%0A").Replace(" ", "%20").ToLower()}" +
                $"&op=translate&rns={new Random().Next(0, 9999)}";

            _browser.Load(url);
        }

        public void TranslateDeepL(string text)
        {
            var url = $"https://www.deepl.com/translator#en/tr/" + HttpUtility.UrlEncode(text)
                .Replace("+", "%20")
                .Replace("%2f", "%5C%2F")
                .Replace("%7c", "%5C%7C");

            _browser.Load(url);
        }

        public Task<JavascriptResponse> EvaluateScript(string code)
        {
            _browser.Focus();

            return _browser.GetMainFrame().EvaluateScriptAsync(code);
        }
    }
}
