using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecutions_N44_HT2
{
    public static class LinqExecution
    {
        public static void Execute()
        {
            var usersCollection = new List<User>()
            {
                new User("Shamsiddin", "Sadriddinov"),
                new User("Abdurahmon", "Shuxratov"),
                new User("Ilhomjon", "Malixov")
            };

            // Deferred execution 
            var deferredQuery = usersCollection.Select(x =>
            {
                Console.WriteLine($"Processing firstName {x.FirstName}");
                return x;
            });

            // Immediate execution
            //var listedQuery = deferredQuery.ToList();
            //var hashQuery = deferredQuery.ToHashSet();
            //var hashQuery = deferredQuery.ToArray();


            // Mixed execution
            var mixedQuery = usersCollection.Take(1);
        }
    }
}
