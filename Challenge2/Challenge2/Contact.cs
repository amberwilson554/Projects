using System;

namespace School
{
    public struct Contact
    {
        private string email;
        private string phone_number;

        public Contact(string email, string phone_number)
        {
            this.email = email;
            this.phone_number = phone_number;
        }

        public void displayContact()
        {
            Console.WriteLine("");
            Console.WriteLine("Email: {0}", this.email);
            Console.WriteLine("Phone Number: {0}", this.phone_number);
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

    }
}
