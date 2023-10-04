using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDelay_N44_HT
{
    public static class EmailSender
    {
        public static async ValueTask Execute()
        {
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            try
            {
                await Sender(cts.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static async ValueTask Sender(CancellationToken cancellationToken)
        {
            for(var index = 0; index < 400; index++)
            {
                if(cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Can't send message");
                    return;
                }
                Console.WriteLine("welcome to our Lesson");

                await Task.Delay(400, cancellationToken);

            }
        }
    }
}
