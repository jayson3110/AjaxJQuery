using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxJQuery.Models
{
    public class Customer
    {
        public  int ID { set; get; }
        public string Name { set; get; }

        public int Age { set; get; }

        public Customer(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}