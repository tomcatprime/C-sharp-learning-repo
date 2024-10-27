namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        //creating default constructor
        public Customer()
        {
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        //Custom Constructor
        
        //Default/option parameters
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
                
        }

        

        //Default parameter contactNumber contactNumber = "NA"
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Doing some customer stuff");
        }   
    }
}
