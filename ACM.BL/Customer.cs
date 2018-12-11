using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }

        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string FullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ", " + FirstName;
                    }
                }
                return FullName;
            }
        }

        public string EmailAddress { get; set; }

        public bool Save()
        {
            //TODO
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            //TODO
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //TODO
            return new List<Customer>();
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
