using System;
using System.Windows.Forms;

namespace WordPool.UI.Extensions
{
    public static class ComponentExtensions
    {
        public static void InvokeControl(this Control control, Action action)
        {
            try
            {
                if (control.InvokeRequired)
                    control.Invoke(new MethodInvoker(delegate { action(); }));
                else
                    action();
            }
            catch (Exception) { }
        }
    }
}
