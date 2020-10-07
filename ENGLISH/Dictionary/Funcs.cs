using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENGLISH
{
    public class Funcs
    {
        public void func()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(0.25), source.Token);
                return 42;
            });

            t.Wait();
        }
    }
}
