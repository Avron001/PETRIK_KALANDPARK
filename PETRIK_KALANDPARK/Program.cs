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
            if (eletkor <= 7)
            {
                return "Mini jegy";
            }
            else if (eletkor <= 15)
            {
                return "Junior jegy";
            }
            else if (eletkor <= 24)
            {
                return "Ifjúsági jegy";
            }
            else if (eletkor <= 59)
            {
                return "Felnőttjegy";
            }
            else
            {
                return "Senior jegy";
            }
            
        }

        static int JegyAr(int eletkor) //nincs kész
        {
            if (eletkor <= 7)
            {
                return 1000;
            }
            else if (eletkor <= 15)
            {
                return 2200;
            }
            else if (eletkor <= 24)
            {
                return 3000;
            }
            else if (eletkor <= 59)
            {
                return 4500;
            }
            else
            {
                return 2800;
            }
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

            // kedző értékek
            int valasztas = 0;
            int bevetel = 0;

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
                                Console.Write("Név: ");
                                string nev = Console.ReadLine();
                                Console.Write("Életkor: ");
                                int eletkor = Convert.ToInt32(Console.ReadLine());
                                if (eletkor < 0 || eletkor > 120)
                                {
                                    Console.WriteLine("Hibás életkor!");
                                }
                                else
                                {
                                    Console.WriteLine($"Szia {nev}!");
                                    Console.WriteLine($"Jegytípus: {JegyTipus(eletkor)}");
                                    Console.WriteLine($"Fizetendő: {JegyAr(eletkor)} Ft");
                                    bevetel += JegyAr(eletkor);
                                }

                                //Console.WriteLine("1");
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
                                Console.WriteLine("=== NAPI BEVÉTEL ===");
                                Console.WriteLine($"A kalandpark mai bevétele: {bevetel} Ft");
                                //Console.WriteLine("4");
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
