using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region variables
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.ReadKey();

            //Console.WriteLine("***YEMEK LİSTESİ***");
            //double appleprize, tomatoprize, potatoprize, orangeprize;
            //appleprize = 15.55;
            //tomatoprize = 21.69;
            //potatoprize = 33.87;
            //orangeprize = 9.37;

            //Console.WriteLine("elma birim fiyatı" + appleprize);
            //Console.WriteLine("domates birim fiyatı" + tomatoprize);
            //Console.WriteLine("patates birim fiyatı" + potatoprize);
            //Console.WriteLine("portakal birim fiyatı" + orangeprize);

            //double applegram = 2.78;
            //double tomatogram = 3.59;
            //double potatogram=1.53;
            //double orangegram=0.15;

            //double appletotal = appleprize * applegram;
            //double tomatototal = tomatoprize * tomatogram;
            //double orangetotal = orangeprize * orangegram;
            //double potatototal = potatoprize * potatogram;

            //Console.WriteLine($"appleprize: {appletotal}");
            //Console.WriteLine($"tomatoprize: {tomatototal}");
            //Console.WriteLine($"patatoprize: {potatototal}");
            //Console.WriteLine($"orangeprize: {orangetotal}");
            //Console.ReadLine();

            #endregion

            #region Klavyeden veri girişi
            //Console.WriteLine("CSharp hava yolları");

            //String passengername, passengersurname, passengernumber, passengercity;
            //Console.Write("yolcuadı giriniz");
            //passengername = Console.ReadLine();
            //Console.WriteLine("yolcusoyadı giriniz");
            //passengersurname = Console.ReadLine();
            //Console.WriteLine("yolcunumarası giriniz");
            //passengernumber = Console.ReadLine();
            //Console.WriteLine("yolcusehrini belirleyiniz");
            //passengercity = Console.ReadLine();

            //Console.WriteLine("YOLCUMUZ" + passengernumber + " " + passengersurname + " " +passengernumber +" "+ passengercity);




            #endregion

            #region Klavyeden tam sayı girişler
            int shoeprize, computerprize, laptopprize;
            shoeprize = 850;
            computerprize = 20000;
            laptopprize = 14000;
            
            int shoecount, computercount, laptopcount;
            Console.WriteLine("Lütfen Aldığınız Ayakkabı Sayısını giriniz");
            shoecount= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Aldığınız Bilgisayar Sayısını giriniz");
            computercount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Aldığınız Laptop Sayısını giriniz");
            laptopcount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("toplam fiyatınız " + (shoecount * shoeprize + computerprize * computercount + laptopprize * laptopcount));
            Console.ReadKey();
            #endregion






        }
    }
}
