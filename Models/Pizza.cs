namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public string? ImgPath { get; set; }

        public string Price { get; set; }
        
        public Pizza(string nome, string? description, string? imgPath, double prezzo)
        {
            Name = nome;
            Description = description;
            ImgPath = imgPath;
            Price = prezzo.ToString("0.00").Replace('.', ',');
        }
    }
}
