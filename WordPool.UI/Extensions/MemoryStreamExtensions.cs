using System.IO;
using System.Text;

namespace WordPool.UI.Extensions
{
    public static class MemoryStreamExtensions
    {
        public static string GetResponse(this MemoryStream memoryStream)
        {
            return Encoding.UTF8.GetString(memoryStream.ToArray(), 0, (int)memoryStream.Length);
        }
    }
}
