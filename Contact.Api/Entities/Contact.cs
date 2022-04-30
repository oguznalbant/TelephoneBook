using Contact.Api.Enums;

namespace Contact.Api.Entities
{
    public class Contact
    {
        public Contact(ContactType contactType, string content)
        {
            this.Type = contactType;
            this.Content = content;
        }

        public ContactType Type { get; set; }

        public string Content { get; set; }

        public int PersonId { get; set; }
    }
}
