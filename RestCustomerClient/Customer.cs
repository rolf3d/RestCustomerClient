using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestCustomerClient
{
    public class Customer
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Customer()
        {

        }

        public Customer(int id, string firstname, string lastname, int year)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _year = year;
        }

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_firstname)}: {_firstname}, {nameof(_lastname)}: {_lastname}, {nameof(_year)}: {_year}";
        }
    }
}
