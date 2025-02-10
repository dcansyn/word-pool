using CefSharp;
using CefSharp.Handler;
using CefSharp.ResponseFilter;
using System;
using System.IO;
using WordPool.UI.Extensions;

namespace WordPool.UI.Handlers
{
    public class PoolResourceRequestHandler : ResourceRequestHandler
    {
        private readonly Action<string, IRequest, IResponse> _eventHandler;
        public PoolResourceRequestHandler(Action<string, IRequest, IResponse> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        private MemoryStream memoryStream;
        protected override IResponseFilter GetResourceResponseFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response)
        {
            memoryStream = new MemoryStream();
            return new StreamResponseFilter(memoryStream);
        }

        protected override void OnResourceLoadComplete(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
        {
            if (memoryStream == null)
                return;

            switch (request.ResourceType)
            {
                case ResourceType.MainFrame:
                case ResourceType.SubFrame:
                case ResourceType.Xhr:
                    var res = memoryStream.GetResponse();

                    _eventHandler?.Invoke(res, request, response);
                    break;
            }
        }

        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            return CefReturnValue.Continue;
        }

        protected override void Dispose()
        {
            memoryStream?.Dispose();
            memoryStream = null;
            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}