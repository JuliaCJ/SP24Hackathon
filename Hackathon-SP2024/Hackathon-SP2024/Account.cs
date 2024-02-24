using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Account
    {
        public string user;
        public string pass;
        public string name;
        public string email;
        public string phone;


        public Account(string user, string pass, string name, string email, string phone)
        {
            this.user = user;
            this.pass = pass;
            this.name = name;
            this.email = email;
            this.phone = phone;

        }
        
        public string getUser()
        {
            return user;
        }

        public string getPass() { 
            return pass;
        }    

        public string getEmail() {
            return email;
        }
        public string getPhone() {
            return phone; 
        }
        public string getName() {
            return name;
        }

        public void setUser(string user)
        {
           this.user=user;
        }

        public void setPass(string pass) { 
             this.pass = pass;
        }    

        public void setEmail(string email) {
            this.email = email;
        }
        public void setPhone(string phone) {
           this.phone= phone; 
        }
        public void setName(string name) {
            this.name= name;
        }

        public bool Login(string tryUser, string tryPass)
        {
            if (this.user == tryUser && this.pass == tryPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract string getType();

        public abstract string OtherInfo();

        public string toSave()
        {
            return getName() + "," + getType() + "," + getUser() + "," + getPass() + "," + getEmail() + "," + getPhone() + "," + OtherInfo();
        }

    }


