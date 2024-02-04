namespace LR1_ASP.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FoundedDate { get; set; }

        public Company(int id, string name, string description, DateTime foundedDate)
        {
            Id = id;
            Name = name;
            Description = description;
            FoundedDate = foundedDate;
        }
    }
}
