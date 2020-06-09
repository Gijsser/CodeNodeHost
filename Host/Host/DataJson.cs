namespace Host
{
    public class DataJson
    {
        public int SensNr { get; set; }
        public int InstNr { get; set; }
        public int BRet { get; set; }
        public int[] Data { get; set; }
        

        public DataJson(int sensNr, int instNr, int bRet, int[] data)
        {
            SensNr = sensNr;
            InstNr = instNr;
            BRet = bRet;
            Data = data;
        }
    }
}
