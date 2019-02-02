using BlockExplorerWrapper.Models;
using System.Threading;
using System.Threading.Tasks;

namespace BlockExplorerWrapper.Interfaces
{
    public interface IBlockExplorerClient
    {
        Task<Block> GetBlockAsync(string hash, CancellationTokenSource cancelToken);
        Task<RawBlock> GetRawBlockAsync(string hash, CancellationTokenSource cancelToken);

        Task<BlockHash> GetBlockHashAsync(string height, CancellationTokenSource cancelToken);
        Task<Transaction> GetTransactionAsync(string txid, CancellationTokenSource cancelToken);
        Task<RawTransaction> GetRawTransactionAsync(string rawtx, CancellationTokenSource cancelToken);
    }
}
