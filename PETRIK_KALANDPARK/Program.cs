using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETRIK_KALANDPARK
{
    internal class Program
    {
        static void MenuKiir() 
        {
            Console.WriteLine("=== PETRIK KALANDPARK ===\n1.) Napijegy vásárlása\n2.) Pálya választása\n3.) Kupon kalkulátor\n4.) Napi bevétel\n5.) Kilépés");
            Console.Write("Választás: ");
        }

        static string JegyTipus(int eletkor) 
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

        static int JegyAr(int eletkor) 
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

        static void PalyaValasztas()
        {
            Console.WriteLine("=== KALANDPÁLYÁK ===");
            Console.WriteLine("1.) Gyerekpálya");
            Console.WriteLine("2.) Erdei pálya");
            Console.WriteLine("3.) Extrém pálya");
            Console.Write("Választás: ");
            int valasztas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Magasság: ");
            int magassag = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
                    {
                        if (magassag < 90)
                        {
                            Console.WriteLine("Nem használhatod ezt a pályát!");
                        }
                        else
                        {
                            Console.WriteLine("Használhatod ezt a pályát!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (magassag < 130)
                        {
                            Console.WriteLine("Nem használhatod ezt a pályát!");
                        }
                        else
                        {
                            Console.WriteLine("Használhatod ezt a pályát!");
                        }
                        break;
                    }
                case 3:
                    {
                        if (magassag < 160)
                        {
                            Console.WriteLine("Nem használhatod ezt a pályát!");
                        }
                        else
                        {
                            Console.WriteLine("Használhatod ezt a pályát!");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nincs ilyen pálya!");
                        break;
                    }
            }


        }

        static int KuponosAr(int ar, int kupon)
        {
            switch (kupon)
            {
                case 2:
                    {
                        return Convert.ToInt32(ar - (ar * 0.10));
                    }
                case 3:
                    {
                        return Convert.ToInt32(ar - (ar * 0.25));
                    }
                default:
                    {
                        return ar;
                    }
            }
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

                                break; 
                            }
                        case 2:
                            {
                                Console.Clear();
                                PalyaValasztas();
                                break; 
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.Write("Eredeti ár: ");
                                int ar = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\n1.) Nincs kupon");
                                Console.WriteLine("2.) SILVER kupon 10%");
                                Console.WriteLine("3.) GOLD kupon 25%");
                                Console.Write("Kupon: ");
                                int kupon = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine($"\nEredeti ár: {ar} Ft");
                                Console.WriteLine($"Kupon: {kupon}");
                                Console.WriteLine($"Fizetendő: {KuponosAr(ar, kupon)} Ft");
                                break; 
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("=== NAPI BEVÉTEL ===");
                                Console.WriteLine($"A kalandpark mai bevétele: {bevetel} Ft");
                                break; 
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Viszlát!");
                                break; 
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Nincs ilyen menüpont!");
                                break; 
                            }
                            
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba! Számot kell megadni!");
                }

                Console.ReadLine();

            }
            while (valasztas != 5);
            
        }
    }
}
