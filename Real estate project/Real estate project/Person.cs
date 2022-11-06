using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_project
{
    class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string userName;
        private string password;
        private string homephoneNumber;
        private string mobilephoneNumber;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public string HomephoneNumber
        {
            get
            {
                return homephoneNumber;
            }

            set
            {
                homephoneNumber = value;
            }
        }
        public string MobilephoneNumber
        {
            get
            {
                return mobilephoneNumber;
            }

            set
            {
                mobilephoneNumber = value;
            }
        }
    }
}
