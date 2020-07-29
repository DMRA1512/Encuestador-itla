using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class Repository
    {
        public List<Person> Persons { get; set; } = new List<Person>();

        public List<NewAccount> CreateAccounts { get; set; } = new List<NewAccount>();

        public static Repository Instance { get; } = new Repository();

        public Repository()
        {

        }
    }
}
