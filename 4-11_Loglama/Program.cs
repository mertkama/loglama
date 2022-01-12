using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_Loglama
{
    class Program
    {
        static void Main(string[] args)
        {
            Loglama();
            Console.ReadLine();
        }

        private static void Loglama()
        {
            try { 
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi==3)
            {
                throw new Exception("Böyle sayi mi olur");
            }
            }
            catch( Exception hata)//Hatanın bilgilerine ulaşmka için exception kullanacaksınız
            {


                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "\r\n");
                File.AppendAllText("log.txt", hata.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine+"********************"+Environment.NewLine);

            }
        }
    }
}
