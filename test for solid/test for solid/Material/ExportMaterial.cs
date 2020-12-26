using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_for_solid.Material
{
    class ExportMaterial
    {
        public bool export(Material material)
        {
            UpdateMaterial upMa = new UpdateMaterial();
            upMa.update(material);

            Console.WriteLine("Exporting {0} {1} {2}\nPrice of one {1} : {3}\nTotal : {0} X {3} = {4}",
                material.quantity, material.unit, material.name, material.price, material.quantity * material.price);
            Console.WriteLine("------------------------------");

            return true;
        }
    }
}
