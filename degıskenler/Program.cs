using System;

namespace degıskenler
{
    class Program
    {
    

        static void Main(string[] args)
        {
            string v = "Tarih ve Saat :";
            Console.WriteLine (v);
            
            DateTime dt = DateTime.Now;
            Console.WriteLine (dt);

            string str = "20";
            int rakam = 20;

            string yeniDeger = str + rakam.ToString();
            Console.WriteLine (yeniDeger);
            
            int newDeger  = rakam + Convert.ToInt32(str);

             Console.WriteLine (newDeger);
            

        }
    }
}
