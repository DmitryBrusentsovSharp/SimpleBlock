using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlock.Models
{
    public class UsersModel
    {
        public string name;
        public string surName;
        public int age = 0;
        public bool hasCar = true;

        public UsersModel(string name, string surName, int age, bool hasCar) 
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
            this.hasCar = hasCar;
        }

        public UsersModel() { }
    }
}