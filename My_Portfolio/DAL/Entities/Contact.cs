using System.Reflection.Metadata.Ecma335;

namespace My_Portfolio.DAL.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
