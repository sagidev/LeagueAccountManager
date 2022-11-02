using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueAccManager
{
    public class Account
    {
        public string Server { get; set; }
        public string Rank { get; set; }
        public bool Smurfq { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string E_Password { get; set; }

        //public Account(string login, string password, string nickname, string server, string email = "", string emailPassword = "")
        //{
        //    Login = login;
        //    Password = password;
        //    Nickname = nickname;
        //    Email = email;
        //    EmailPassword = emailPassword;
        //    Server = server.ToUpper();
        //}

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Account))
        //    {
        //        return false;
        //    }
        //    Account a = (Account)obj;
        //    return Login.Equals(a.Login) && Server == a.Server;
        //}

        //zatb90274:Accforsale1:Catherinenkksc:sagithe:sagithe:EUW

    }
}
