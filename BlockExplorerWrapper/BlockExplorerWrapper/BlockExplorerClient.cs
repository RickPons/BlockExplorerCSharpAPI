using BlockExplorerWrapper.Interfaces;
using BlockExplorerWrapper.Models;
using Flurl.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace BlockExplorerWrapper
{
    public class BlockExplorerClient: IBlockExplorerClient
    {
        private static readonly string ApiUrl = "https://blockexplorer.com/api/";

        public Task<Block> GetBlockAsync(string hash, CancellationTokenSource cancelToken)
        {
            var petitionUrl = $"{ApiUrl}block/{hash}";
            return petitionUrl.GetJsonAsync<Block>(cancelToken.Token);

           
        }

        public Task<BlockHash> GetBlockHashAsync(string height, CancellationTokenSource cancelToken)
        {
            var petitionUrl = $"{ApiUrl}block-index/{height}";
            return petitionUrl.GetJsonAsync<BlockHash>(cancelToken.Token);
        }

        public Task<RawBlock> GetRawBlockAsync(string hash, CancellationTokenSource cancelToken)
        {
            var petitionUrl = $"{ApiUrl}rawblock/{hash}";
            return petitionUrl.GetJsonAsync<RawBlock>(cancelToken.Token);
        }

        public Task<RawTransaction> GetRawTransactionAsync(string rawtx, CancellationTokenSource cancelToken)
        {
            var petitionUrl = $"{ApiUrl}rawtx/{rawtx}";
            return petitionUrl.GetJsonAsync<RawTransaction>(cancelToken.Token);
        }

        public Task<Transaction> GetTransactionAsync(string txid, CancellationTokenSource cancelToken)
        {
            var petitionUrl = $"{ApiUrl}tx/{txid}";
            return petitionUrl.GetJsonAsync<Transaction>(cancelToken.Token);
        }
    }
}
