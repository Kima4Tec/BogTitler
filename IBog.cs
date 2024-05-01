namespace BogTitler
{
    public interface IBog
    {
        int Id { get; set; }
        string Titel { get; set; }
        string Forfatter { get; set; }
        string Genre { get; set; }
        string Emne { get; set; }

    }
}