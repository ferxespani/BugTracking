using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            Random r = new Random();
            int choice = 0;
            for(int i = 0; i < 10; i++)
            {
                choice = r.Next(1, 4);
                if(choice == 1)
                {
                    
                }
            }
        }
    }
}
