using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_SP2024
{
    public class Person : Account
    {
        List<bool> helpNeeded = new List<bool>();
        string gender;
        string bday;

        public Person(string user, string pass, string name, string email, string phone, string gender, string bday) : base(user, pass, name, email, phone)
        {
            this.gender = gender;
            this.bday = bday;
        }

        public string getBday()
        {
            return bday;
        }

        public string getGender()
        {
            return gender;
        }

        public void setBday(string bday)
        {
            this.bday = bday;
        }

        public void serGender(string gender)
        {
            this.gender = gender;
        }

        public override string getType()
        {
            return "Person";
        }
        public override string OtherInfo()
        {
            return this.gender + "," + this.bday;

        }
    }
}
