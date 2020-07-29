using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    [Serializable]
    public class NewAccount : Person
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string name { get; set; }

        public string passwordf { get; set; }

        public NewAccount(string name, string lastname) : base(name, lastname)
        {



        }
        public NewAccount()
        {
        }
    }
}
