using System;

namespace BusinessLayer
{ 
    [Serializable]
    public class Person
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;

        }

        public Person()
        { 
        }
       
    }
}
