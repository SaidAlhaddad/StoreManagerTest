using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_for_solid.Models.Material
{
    class DeleteMaterial
    {
        public bool delete(Material material)
        {
            if (material.isExist())
            {
                //Delete existing material
                Console.WriteLine("Material deleted");//this must delete
                return true;
            }
            Console.WriteLine("Material not deleted");//this must delete
            return false;
        }
    }
}
