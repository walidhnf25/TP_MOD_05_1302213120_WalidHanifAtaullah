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

            // Panggil method PrintData dari class DataGeneric
            DataGeneric<string> dataString = new DataGeneric<string>("1302213120");
            dataString.PrintData();
        }
    }


    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
