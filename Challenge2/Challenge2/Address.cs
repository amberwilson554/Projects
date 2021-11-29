using System;

namespace School
{
    public struct Address
    {
        private string street;
        private string zipcode;
        private string city;
        private string state;

        public Address(string street, string zipcode, string city, string state)
        {
            this.street = street;
            this.zipcode = zipcode;
            this.city = city;
            this.state = state;
        }
        public void displayAddress()
        {
            Console.WriteLine("");
            Console.WriteLine("Street: {0}", this.street);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("State: {0}", this.state);
            Console.WriteLine("Zipcode: {0}", this.zipcode);
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }

}
