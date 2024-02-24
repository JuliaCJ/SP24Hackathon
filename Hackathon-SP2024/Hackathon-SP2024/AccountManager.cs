using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_SP2024
{
    
    public class AccountManager
    {
        List<Account> allAccounts = new List<Account>();
        List<Helper> allHelpers = new List<Helper>();
   

        public AccountManager()
        {
            StreamReader sr = new StreamReader("C:\\Users\\cjohn\\source\\repos\\Hackathon-SP2024\\SP24Hackathon.csv");
            string line = sr.ReadLine();
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                string[] data = line.Split(',');
                string name = data[0];
                string type = data[1];
                string user = data[2];
                string pass = data[3];
                string email = data[4];
                string phone = data[5];
                string gen = data[6];
                string bday = data[7];
                string des = data[8];
                string hours = data[9];
                int capacity = Convert.ToInt32(data[10]);
                int current = Convert.ToInt32(data[11]);
                string limits = data[12];
                string address = data[13];

                if (limits == "N/A")
                {
                    limits = "No Limitations";
                }

                if (type == "Person")
                {
                    allAccounts.Add(new Person(user, pass, name, email, phone, gen, bday));
                }
                else
                {
                    allAccounts.Add(new Helper(user, pass, name, email, phone, des, hours, capacity, current, limits, address));
                    allHelpers.Add(new Helper(user, pass, name, email, phone, des, hours, capacity, current, limits, address));
                }
                line = sr.ReadLine();
            }
            
            sr.Close();

        } 

        public List<Account> getAccounts()
        {
            return allAccounts;
        }
        public void setAccounts(List<Account> accounts)
        {
            allAccounts = accounts;
        }

        public List<Helper> getHelpers()
        {
            return allHelpers ;
        }

        public void addPerson(string name, string user, string pass, string email, string phone, string gen, string bday)
        {
            allAccounts.Add(new Person(user, pass, name, email, phone, gen, bday));
        }

        public void addHelper(string user, string pass, string name, string email, string phone, string des, string hours, int cap, int current, string limits, string address)
        {
            allAccounts.Add(new Helper(user, pass, name, email, phone, des, hours, cap, current, limits, address));
        }

        public void saveAccounts()
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\cjohn\\source\\repos\\Hackathon-SP2024\\SP24Hackathon.csv");
            sw.WriteLine("Name,Account Type,Username,Password,Email,Phone,Gender,Birthday,Description,Hours,Capcity,Current Capacity,Limits,Address");
            foreach (Account a in allAccounts)
            {
         
                if (a is Person)
                {
                    sw.Write(a.toSave());
                    for (int i = 0; i < 6; i++)
                    {
                        if (i < 2 || i > 3) { 

                        sw.Write(",-");

                        } else
                        {
                            sw.Write(",-1");
                        }

                    }
                    sw.WriteLine();
                }
                else
                {
                    sw.WriteLine(a.toSave());
                }
            }
            sw.Close();

        }
    }
}

