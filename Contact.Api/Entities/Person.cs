namespace Contact.Api.Entities
{
    public class Person
    {
        public Person(string name, string surname, string company)
        {
            this.Name = name;
            this.Surname = surname;
            this.Company = company;
        }

        public Guid UUID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Company { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
