using CefSharp;
using CefSharp.Handler;
using System;

namespace WordPool.UI.Handlers
{
    public class PoolRequestHandler : RequestHandler
    {
        private readonly Action<string, IRequest, IResponse> _eventHandler;
        public PoolRequestHandler(Action<string, IRequest, IResponse> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new PoolResourceRequestHandler(_eventHandler);
        }
    }
}
