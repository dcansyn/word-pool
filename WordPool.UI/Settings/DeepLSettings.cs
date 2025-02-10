using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPool.UI.Settings
{
    public class DeepLSettings
    {
        public static string[] Codes = new[]
        {
            "document.querySelector('#headlessui-portal-root').style.display = 'none';",
            "document.querySelector('[data-testid=dl-cookieBanner]').style.display = 'none';",
            "document.querySelector('header').style.display = 'none';",
            "document.querySelector('.space-y-6 .flex').style.display = 'none'",
            //"document.querySelectorAll('[data-testid=translator] > div').forEach((item,i) => { if(!item.classList.contains('contextual-menu-dragging-area')){item.style.display = 'none'}});",
            "document.querySelector('footer').style.display = 'none';"
        };
    }
}