namespace Denwme
{
    public class Synonmys
    {
        public int Id { get; set; }
        public string SyName { get; set; }
        public string Meaning { get; set; }
        public Word Word { get; set; }
        public int WordId { get; set; }
    }
}