using app.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DL
{
    public class User_DL
    {
        private static List<User> userlist = new List<User>();
        public static List<User> List { get { return userlist; } set { userlist = value; } }
        public static User Login(string email, string password)
        {
            foreach (var user in userlist)
            {
                if ((user.Email == email) && (user.Password == password))
                {
                    return user;
                }
            }
            return null;
        }
        public static bool isAdminExist(string role)
        {
            bool isAdmin = false;
            foreach (var user in userlist)
            {
                if (user.Role.Equals(role))
                {
                    isAdmin = true;
                }
            }
            return isAdmin;
        }
        public static bool isUserExist(string name)
        {
            bool namecondition = false;
            foreach (User user in userlist)
            {
                if (user.Name == name)
                {
                    return namecondition = true;
                }
            }
            return namecondition;
        }
        public static bool isMailAddressExist(string mail)
        {
            bool mailcondition = false;
            foreach (User user in userlist)
            {
                if (user.Email == mail)
                {
                    mailcondition = true;
                }
            }
            return mailcondition;
        }
        public static void Add_User_into_list(User u)
        {
            userlist.Add(u);
        }
        public static User retrieve_user_from_list(Tuple<string, string> u)
        {
            foreach (var user in userlist)
            {
                if (user.Name.Equals(u.Item1) && user.Email.Equals(u.Item2))
                {
                    return user;
                }
            }
            return null;
        }
        public static bool delete_user_from_list(Tuple<string, string> u)
        {
            foreach (var user in userlist)
            {
                if (user.Name.Equals(u.Item1) && user.Email.Equals(u.Item1))
                {
                    userlist.Remove(user);
                    return true;
                }
            }
            return false;
        }
        public static int view_User_list(string status)
        {
            foreach (var customer in userlist)
            {
                if (customer.Role.Equals(status))
                {
                    //User_UI.view_user_list(customer);
                }
            }
            return 0;
        }
        public static bool storeintofile(User person, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(person.Name + "," + person.Email + "," + person.Password + "," + person.Role);
            file.Flush();
            file.Close();
            return true;
        }
        public static void readfromfile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string name = splittedrecord[0];
                    string email = splittedrecord[1];
                    string password = splittedrecord[2];
                    string role = splittedrecord[3];
                    Customer user = new Customer(name, email, password, role);
                    userlist.Add(user);
                }
                file.Close();
            }
        }
    }
}
