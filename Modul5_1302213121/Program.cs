// See https://aka.ms/new-console-template for more information

namespace Modul5_1302213121
{
    internal class Program
    {
        public class Penjumlahan
        {
            public static void JumlahTigaAngka<T>(T a, T b, T c)
            {
                dynamic penjumlahan = (dynamic)a + (dynamic)b + (dynamic)c;
                Console.WriteLine("Hasil Penjumlahan: " + penjumlahan);
            }
        }
        static void Main(String[] args)
        {
            //1302213121
            Penjumlahan.JumlahTigaAngka<float>(13, 02, 21);
        }
    }
}



