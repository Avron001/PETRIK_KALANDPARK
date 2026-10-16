using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETRIK_KALANDPARK
{
    internal class Program
    {

        //static void MenuKiir()
        //static string JegyTipus(int eletkor)
        //static int JegyAr(int eletkor)
        //static void PalyaValasztas()
        //static int KuponosAr(int ar, int kupon)

        static void MenuKiir() // kész
        {
            Console.WriteLine("=== PETRIK KALANDPARK ===\n1.)Napijegy vásárlása\n2.)Pálya választása\n3.)Kupon kalkulátor\n4.) Napi bevétel\n5.)Kilépés");
            Console.Write("Választás: ");
        }

        static string JegyTipus(int eletkor) //nincs kész
        {
            return "";
        }

        static int JegyAr(int eletkor) //nincs kész
        {
            return 0;
        }

        static void PalyaValasztas() //nincs kész
        {

        }

        static int KuponosAr(int ar, int kupon) //nincs kész
        {
            return 0;
        }

        static void Main(string[] args)
        {
            int valasztas = 0;
            do
            {
                try
                {
                    Console.Clear();
                    MenuKiir();
                    valasztas = Convert.ToInt32(Console.ReadLine());

                    switch (valasztas)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("1");
                                break; 
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("2");
                                break; 
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("3");
                                break; 
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("4");
                                break; 
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Viszlát!");
                                break; 
                            }
                            
                    }

                    Console.Read();



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba! Számot kell megadni!");
                }
            }
            while (valasztas != 5);
            
        }
    }
}
