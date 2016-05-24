using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LFA.Data
{
    /// <summary>
    /// User class for storing USername password
    /// </summary>
    public class LFAUser
    {
        #region Constructor
        public LFAUser()
        {
            UserName = "guest";
            Password = "password";
        }
        /// <summary>
        /// Creating parameterized constructor
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public LFAUser(string userName,string password){
            UserName = userName;
            Password = password;
        }        
        #endregion
        
        #region Public Members
        public int UserID { get; set; }
        public string UserName { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region public method
        public void Authenticate()
        {
            if(UserName=="admin" && Password=="password")
            {
                Console.WriteLine("Welcome {0} you are logged in as Admin", UserName);
            }
            else if (UserName == "user" && Password == "password")
            {
                Console.WriteLine("Welcome {0} you are logged in as normal user", UserName);
            }
            else
                Console.WriteLine("Invalid User");
        }
        public string Authenticate(string userName, string password)
        {
            if ((userName == "admin" && Password == "password") || (userName == "user" && Password == "password"))
            {
                this.UserName = userName;
                return UserName;
            }
            //else if (UserName == "admin" && Password == "password")
            //{
            //    Console.WriteLine("Welcome {0} you are logged in as normal user", UserName);
            //}
            else
                return "anonymous";
        }
        public bool Authenticated(string userName="anonymous",string password="password")
        {
            return ((userName == "admin" && password == "password") || (userName == "user" && password == "password"));
        }

        public bool Auth(ref string role, string userName="anonymous", string password="password")
        {
            string strRole = "guest";
            if(userName == "admin" && password == "password")
               role="admin";            
            else if(userName == "user" && password == "password")
                role = "user";
            strRole = role;
            return strRole == "guest"? false : true;
        }
        public bool AuthOut(ref string role, string userName = "anonymous", string password = "password")
        {
            string strRole = "guest";
            if (userName == "admin" && password == "password")
                role = "admin";
            else if (userName == "user" && password == "password")
                role = "user";
            strRole = role;
            return strRole == "guest" ? false : true;
        }

        #endregion
        #region class as return type
        public LFAUser GetUser(string userName = "anonymous", string password = "password")
        {
            this.UserName = userName;
            this.Password = password;
            return this;

            LFAUser objUser = new LFAUser(UserName = userName, Password = password);
            return objUser;

            LFAUser objUser1 = new LFAUser();
            objUser1.UserName = userName;
            objUser1.Password = password;
            return objUser1;
        }
        #endregion

    }
}
