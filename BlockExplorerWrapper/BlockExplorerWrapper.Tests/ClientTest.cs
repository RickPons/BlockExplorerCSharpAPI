using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace BlockExplorerWrapper.Tests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public async Task GetBlockTest()
        {
            var client = new BlockExplorerClient();
           var result= await  client.GetBlockAsync("0000000000000000079c58e8b5bce4217f7515a74b170049398ed9b8428beb4a", new System.Threading.CancellationTokenSource());
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BlockExplorerWrapper.Models.Block));
        }
    }
}
