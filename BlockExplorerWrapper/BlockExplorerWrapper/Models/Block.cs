namespace BlockExplorerWrapper.Models
{

    public class Block
    {
        public string hash { get; set; }
        public int size { get; set; }
        public int height { get; set; }
        public int version { get; set; }
        public string merkleroot { get; set; }
        public string[] tx { get; set; }
        public int time { get; set; }
        public long nonce { get; set; }
        public string bits { get; set; }
        public float difficulty { get; set; }
        public string chainwork { get; set; }
        public int confirmations { get; set; }
        public string previousblockhash { get; set; }
        public string nextblockhash { get; set; }
        public int reward { get; set; }
        public bool isMainChain { get; set; }
    }

  

}
