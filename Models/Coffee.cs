namespace API_Interactive_Lab_1.Models
{
    public class Coffee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Coffee(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public override string ToString()
        {
            return $"Name:{Name} Id:{Id}";
        }
    }
}
