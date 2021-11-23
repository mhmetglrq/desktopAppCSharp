namespace Denwme
{
    public class Sentence
    {
        public int Id { get; set; }
        public string Sentences { get; set; }
        public string Meaning { get; set; }
        public Word Word { get; set; }
    }
}