using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing2_10
{
    class Listing2_10
    {
        static void Main(string[] args)
        {
            // create cancelation token source
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            // create cancelation token
            CancellationToken token = tokenSource.Token;

            // create task1
            Task task1 = new Task(() => {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    token.ThrowIfCancellationRequested();
                    //cw
                }
            }, token);
            
        }
    }
}
