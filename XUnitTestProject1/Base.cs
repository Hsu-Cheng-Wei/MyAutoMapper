using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class Base : IAsyncLifetime
    {

        public Task DisposeAsync()
        {
            Console.WriteLine("Dispose");
            return Task.CompletedTask;
        }

        public Task InitializeAsync()
        {
            Console.WriteLine("Start");
            return Task.CompletedTask;
        }
    }
}
