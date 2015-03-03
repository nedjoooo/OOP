using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer
{
    class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;

        public Customer(string firstName, string middleName, string lastName, string id, 
            string address, string phone, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.Address = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Firstname cannot be empty.");
                }

                if (!Regex.IsMatch(value, @"^[A-Z][a-z]+$"))
                {
                    throw new ArgumentException("Please enter a valid name.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middlename cannot be empty.");
                }

                if (!Regex.IsMatch(value, @"^[A-Z][a-z]+$"))
                {
                    throw new ArgumentException("Please enter a valid name.");
                }


                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Lastname cannot be empty.");
                }

                if (!Regex.IsMatch(value, @"^[A-Z][a-z]+$"))
                {
                    throw new ArgumentException("Please enter a valid name.");
                }


                this.lastName = value;
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ID cannot be empty.");
                }

                // probvah da izmislq nakakuv regex za egn ama ne e mn hubav zashtoto hvashta 31 fevruari primerno
                // http://regexhero.net/tester/
                if (value.Length != 10 || !Regex.IsMatch(value, @"^\d{2}((0[1-9])|(10|11|12))((0[1-9])|(([1-2][0-9])|(3[0-1])))\d{4}$"))
                {
                    throw new ArgumentException("Please enter a valid ID.");
                }

                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address cannot be empty.");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                // http://stackoverflow.com/questions/5066329/regex-for-valid-international-mobile-phone-number
                if (!Regex.IsMatch(value, @"^\+[1-9]{1}[0-9]{3,14}$+") || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter a valid phone number.");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                // http://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp
                if (!Regex.IsMatch(value, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?") ||
                    string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter a valid email.");
                }

                this.email = value;
            }
        }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if(customer == null)
            {
                return false;
            }

            List<Object> thisCustomer = new List<object>()
            {
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.Address,
                this.MobilePhone,
                this.Email
            };

            List<Object> submittedCustomer = new List<object>()
            {
                customer.FirstName,
                customer.MiddleName,
                customer.LastName,
                customer.ID,
                customer.Address,
                customer.MobilePhone,
                customer.Email
            };

            for (int i = 0; i < thisCustomer.Count; i++)
            {
                if(!(Object.Equals(thisCustomer[i], submittedCustomer[i])))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return String.Format("Customer Name: {0} {1} {2}{3}ID: {4}{3}Address: {5}{3}Mobile phone: {6}{3}Email: {7}{3}",
                this.FirstName, this.MiddleName, this.LastName, Environment.NewLine,
                this.ID, this.Address, this.MobilePhone, this.Email);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^
                ID.GetHashCode() ^ Address.GetHashCode() ^ MobilePhone.GetHashCode() ^ Email.GetHashCode();
        }

        public static bool operator ==(Customer thisCustomer, Customer submittedCustomer)
        {
            return Customer.Equals(thisCustomer, submittedCustomer);
        }

        public static bool operator !=(Customer thisCustomer, Customer submittedCustomer)
        {
            return !(Customer.Equals(thisCustomer, submittedCustomer));
        }

        public object Clone()
        {
            var copy = this.MemberwiseClone();
            (copy as Customer).Payments = new List<Payment>();
            foreach (var payment in this.Payments)
            {
                var copyPaiment = new Payment(payment.ProductName, payment.Price);
                (copy as Customer).Payments.Add(copyPaiment);
            }

            return copy;
        }

        public int CompareTo(Customer submittedCustomer)
        {
            string thisName = this.FirstName + this.MiddleName + this.LastName;
            string submittedName = submittedCustomer.FirstName + submittedCustomer.MiddleName + submittedCustomer.LastName;
            if(thisName.CompareTo(submittedName) == 0)
            {
                return this.ID.CompareTo(submittedCustomer.ID);
            }
            return thisName.CompareTo(submittedName);
        }

    }
}
