using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_SP2024
{
    public class Helper : Account
    {
        string des;
        string hours;
        int cap;
        int current;
        float percentFull;
        string limits;
        string address;

        public Helper(string user, string pass, string name, string email, string phone, string des, string hours, int cap, int current, string limits, string address) : base(user, pass, name, email, phone)
        {
            this.des = des;
            this.cap = cap;
            this.hours = hours;
            this.cap = cap;
            this.current = current;
            this.limits = limits;
            this.address = address;

            percentFull = ((float)current / (float)cap) * 100;
        }

        public string getDes()
        {
            return des;
        }

        public string getHours()
        {
            return hours;
        }

        public int getCap()
        {
            return cap;
        }

        public int getCurrent()
        {
            return current;
        }

        public float getPercentFull()
        {
            return percentFull;
        }
        public string getLimits()
        {
            return limits;
        }

        public string getAddress()
        {
            return address;
        }

        public override string getType()
        {
            return "Helper";
        }
        public void setDes(string Des)  
        {
            this.des = Des;
        }

        public void setHours(string hours)
        {
         this.hours= hours;
        }

        public void setCap(int cap)
        {
            this.cap = cap;
        }

        public void setCurrent(int current)
        {
           this.current= current;
            percentFull= ((float)current / (float)cap)*100;
        }

        public void setLimits(string limits)
        {
          this.limits = limits;
        }

        public void setAddress(string adrs)
        {
            this.address = adrs;
        }

        public string prettyDes()
        {
            string[] line = this.des.Split(';');
            string newDes = "";
     

            foreach (string s in line)
            {
              
                newDes += s + "\n";
             
            }
            return newDes;
        }

        public string prettyAdrs()
        {
            string[] line = this.address.Split(';');
            string adrs = "";
            bool first = true;

            foreach (string s in line)
            {
        
                adrs += s + "\n";
             
            }
            
            return adrs;
        }

        public override string OtherInfo()
        {
            return "-,-," + this.des + "," + this.hours + "," + this.cap + "," + this.current + "," + this.limits + "," + this.address;
        }

        public override string ToString()
        {
            return this.name + "\n" + prettyAdrs()  + this.limits + "\n" + this.hours + "\n" + "This location is " + this.percentFull + "% full.";
        }

    }
}
