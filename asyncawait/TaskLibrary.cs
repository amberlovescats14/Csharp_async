using System;
using System.IO;
using System.Threading.Tasks;

namespace asyncawait
{
    public class TaskLibrary
    {
        public void example()
        {
            var req = Task.Run(() =>
            {
                var lines = File.ReadAllLines(@"C:\Users\amber.jones\Desktop\abc.txt");
                return lines;
            });
            req.ContinueWith( t =>
            {
                var res = req.Result;
            });
        }
    }
}
