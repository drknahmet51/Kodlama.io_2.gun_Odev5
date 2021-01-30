using System;

namespace PcCekilisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------KATILIMCILAR-----------");

            string[] Isım = new string[] { "Burak Kamber", "Ali Can", "Serdar Doğan", "Arif Elmas", "Kemal Cansever", "Yaşar Gül","Eren Güçlü" };

            for (int i = 0; i < Isım.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Katılımcı " + "Adı-Soyadı: " + Isım[i]);

            }

            Console.WriteLine("Toplam Katılımcı Sayısı: " + Isım.Length);
        }
    }
}
