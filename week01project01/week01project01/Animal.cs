using System;
using System.Collections.Generic;
using System.Text;

namespace week01project01
{
    class Animal
    {
        public string Name { get; set; }

        public string OwnerName { get; set; }


        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                _age = value;
            }
        }

        public int LegCount { get; set; }

        public Animal(string name,string ownername,int age, int legcount)
        {
            this.Name = name;
            this.OwnerName = ownername;
            this.Age = age;
            this.LegCount = legcount;
        }
    }

    class Cat:Animal
    {
        public int Lives;

        public Cat(string name, string ownername, int age) : base(name, ownername, age, 4)
        {
            this.Lives = 9;
        }


        public void KillCat()
        {
            Lives = Lives - 1;
        }
        public bool TryKillCat()
        {
            if (Lives > 0)
            { Lives = Lives-1;
                return true;
            }
            return false;
        }
    }
}
