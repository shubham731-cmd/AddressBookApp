namespace AddressBookApp
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}");
        }
    }
}
