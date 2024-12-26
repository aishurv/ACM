using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
        
        public int CustomerID { get; set; }
        public static int InstanceCount { get; set; }
        public string EmailAddress { get; set; }
        public string LastName{ get; set; }
        public string FirstName{ get; set; }


        public string FullName
        {
            get 
            {
                String fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(FirstName))
                    {
                        fullName += " " ;
                    }
                    fullName += LastName;
                }
                return fullName;    
            }
        }
        public bool Validate()
        {
            var isValide =true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValide = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValide = false;

            return isValide;
        }
        public Customer Retrive(int customerID) 
        {
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }





    }
}
