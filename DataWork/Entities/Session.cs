namespace DataWork.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string NameFilm { get; set; }
        public string Hall { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Price { get; set; }
    }
}
