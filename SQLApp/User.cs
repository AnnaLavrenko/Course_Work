using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _userName;
        private DateTime _birthDay;
        private bool isBirthDayToday;

        public bool IsBirthDayToday
        {
            get { return isBirthDayToday; }
            set { isBirthDayToday = value; }
        }


        public User(string userName)
        {
            _userName = userName;
        }
        public User(string userName, DateTime birthDay)
        {
            _userName = userName;
            _birthDay = birthDay;
        }


        public bool IsBirthDayToDay()
        {
            if (DateTime.Today == _birthDay && DateTime.Today.AddDays(3) == _birthDay.AddDays(3))
            {
                return true;
            }
            return false;
        }

        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

    }
}
