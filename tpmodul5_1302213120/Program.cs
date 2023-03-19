using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302213120
{
    class Program
    {
        static void Main(string[] args)
        {
            string namaPanggilan = "Walid";
            HaloGeneric.SapaUser(namaPanggilan);
        }
    }

    public class HaloGeneric
    {
        public static void SapaUser<T>(T input)
        {
            Console.WriteLine("Halo user " + input);
        }
    }
}
