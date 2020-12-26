using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_for_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Material.Material m1 = new Material.Material("Shminto", "Kies", 5000, 5);
            Material.ImportMaterial imMa = new Material.ImportMaterial();
            imMa.import(m1);


            Console.ReadKey();
        }
    }
}
