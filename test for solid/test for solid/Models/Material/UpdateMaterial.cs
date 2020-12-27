using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_for_solid.Models.Material
{
    class UpdateMaterial
    {
        public bool update(Material material)
        {
            if (material.isExist())
            {
                //Update existing material
                Console.WriteLine("Material updated");//this must delete
                return true;
            }
            Console.WriteLine("Material not updated");//this must delete
            return false;
        }
    }
}
