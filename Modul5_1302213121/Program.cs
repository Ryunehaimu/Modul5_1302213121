// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace Modul5_1302213121
{
    internal class Program
    {
        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }
            public void AddNewData(T data) {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }
            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data 1 berisi: "+storedData[i]+ ", yang disimpan pada waktu UTC: " + inputDates[i]+" AM");
                }
            }
        }
        public class Penjumlahan
        {
            public static void JumlahTigaAngka<T>(T a, T b, T c)
            {
                dynamic penjumlahan = (dynamic)a + (dynamic)b + (dynamic)c;
                Console.WriteLine("Hasil Penjumlahan: " + penjumlahan);
            }
        }
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<float>(13, 02, 21);
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.AddNewData(12.0f);
            data.AddNewData(34.0f);
            data.AddNewData(56.0f);
            data.PrintAllData();
            //1302213121-Dede Rahmat Fitriansyah
        }
    }
}
