using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_for_solid.Models.Material;

namespace test_for_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Material m1 = new Material("Shminto", "Kies", 5000, 5);
            ImportMaterial imMa = new ImportMaterial();
            imMa.import(m1);


            Console.ReadKey();
        }
    }
}
