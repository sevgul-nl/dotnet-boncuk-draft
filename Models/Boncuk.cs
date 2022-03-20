namespace eBoncuk.Models
{
    public class Boncuk
    {
        public int BoncukID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}