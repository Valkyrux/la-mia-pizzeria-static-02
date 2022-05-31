namespace la_mia_pizzeria_static.Models
{
    public class Pizzeria
    {
        public string Nome;
        public List<Pizza> listaPizze;
        public Pizzeria(string nome)
        {
            this.Nome = nome;
            listaPizze = new List<Pizza>();
        }
        public void addPizza(Pizza pizza)
        {
            this.listaPizze.Add(pizza);
        }
    }
}
