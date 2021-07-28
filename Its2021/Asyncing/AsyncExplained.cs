using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Its2021
{
    public class AsyncExplained
    {
        public static async Task RunAsync()
        {
            await WriteAsync().ConfigureAwait(false);
            await Write2Async().ConfigureAwait(false);
        }
        private static async Task WriteAsync()
        {
            var writer = new StreamWriter("C:/file.txt");
            var writer2 = new StreamWriter("C:/file2.txt");
            await Task.WhenAll(writer.WriteAsync("dasdsadsadasd"), writer2.WriteAsync("dasdsadsadasd")).ConfigureAwait(false);
            await writer.WriteAsync("dadsadsasad").ConfigureAwait(false);
            await writer2.WriteAsync("dadsadsasad").ConfigureAwait(false);
        }
        private static Task Write2Async()
        {
            var writer = new StreamWriter("C:/file.txt");
            return writer.WriteAsync("dadsadsasad");
        }

    }
}
