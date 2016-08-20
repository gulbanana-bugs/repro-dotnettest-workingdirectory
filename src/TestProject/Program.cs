using System.IO;
using Xunit;

namespace TestProject
{
    public class Program
    {
        [Fact]
        public void Test()
        {
            Assert.True(File.Exists("data.txt"));
        }
    }
}
