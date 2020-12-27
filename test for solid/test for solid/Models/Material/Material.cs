using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_for_solid.Models.Material
{
    class Material
    {
        public int id;
        public string name;
        public string unit;
        public double price;
        public int quantity;

        public Material(int id, string name, string unit, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.unit = unit;
            this.price = price;
            this.quantity = quantity;
        }

        public Material(string name, string unit, double price, int quantity)
        {
            this.name = name;
            this.unit = unit;
            this.price = price;
            this.quantity = quantity;
        }

        public bool isExist() { return true; }
    }
}
