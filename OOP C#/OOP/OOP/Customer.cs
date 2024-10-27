using System.Drawing;

namespace ClassesApp
{
    internal class Customer
    {

        private static int nextID = 0;

        //Read-only instance field initialized from the constructor
        private readonly int _id;

        //Backing field for write-only property.
        private string _password;
        //Setting getter for password
        public string Password { set
            {
                _password = value;
            }
        }

        //Read-Only property
        public int Id
        {
            get
            {
                return _id;
            }
        }


        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        //creating default constructor
        public Customer()
        {
            _id = nextID++;
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        //Custom Constructor
        
        //Default/option parameters
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextID++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
                
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about customer: {Name} and ID is {_id}");
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
