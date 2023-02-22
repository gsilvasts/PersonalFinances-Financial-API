namespace PersonalFinances.Financial.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category(string description, string name)
        {
            Description = description;
            Name = name;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
