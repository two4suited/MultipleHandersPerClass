namespace src
{
    public class Message
    {
        public string key1 { get; set; }
        public void Upper()
        {
            key1 = key1.ToUpper();
        }
        public void Lower()
        {
            key1 = key1.ToLower();
        }
    }
}
