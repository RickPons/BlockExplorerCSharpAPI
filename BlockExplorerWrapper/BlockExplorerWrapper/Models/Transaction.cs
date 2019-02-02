namespace BlockExplorerWrapper.Models
{

    public class Transaction
    {
        public string txid { get; set; }
        public int version { get; set; }
        public int locktime { get; set; }
        public Vin[] vin { get; set; }
        public Vout[] vout { get; set; }
        public string blockhash { get; set; }
        public int blockheight { get; set; }
        public int confirmations { get; set; }
        public int time { get; set; }
        public int blocktime { get; set; }
        public bool isCoinBase { get; set; }
        public float valueOut { get; set; }
        public int size { get; set; }
    }

    public class Vin
    {
        public string coinbase { get; set; }
        public long sequence { get; set; }
        public int n { get; set; }
    }

    public class Vout
    {
        public string value { get; set; }
        public int n { get; set; }
        public Scriptpubkey scriptPubKey { get; set; }
        public string spentTxId { get; set; }
        public int spentIndex { get; set; }
        public int spentHeight { get; set; }
    }

    public class Scriptpubkey
    {
        public string hex { get; set; }
        public string asm { get; set; }
        public string[] addresses { get; set; }
        public string type { get; set; }
    }

}
