using System;
using System.IO;
using System.Threading.Tasks;
//
// you cant use Dispatcher on Mac because it is a windows task
//using System.Windows.Threading;

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
                //if this throws and exception dispatcher will still run
                var res = req.Result;

                //Dispatcher.Invoke(() => this.story = res);
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            req.ContinueWith(t =>
            {
                //Dispatcher.Invoke(() =>
                //{
                //    Notes.Text = t.Exception.InnerException.Message;
                //}, TaskContinuationOptions.OnlyOnFaulted);
            });

        }




    }
}
