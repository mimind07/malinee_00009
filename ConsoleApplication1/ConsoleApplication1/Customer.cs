using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer
    {
        public int Id{ get; set; }
        public String Name { get; set; }
        public Customer(){}
        public Customer(int id, String name)
        {
            this.Id = id;
            this.Name=name;
        }
        public void Info()
        {
            Console.WriteLine(id + ":" + Name);
        }


        public string id { get; set; }
    }
    
}
