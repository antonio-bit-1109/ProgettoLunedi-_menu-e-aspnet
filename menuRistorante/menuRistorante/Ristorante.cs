using System;

namespace menuRistorante
{
    internal static class Ristorante
    {
        public static void Benvenuto()
        {
            cliente cliente1 = new cliente();
            Console.WriteLine("inserisci nome");
            string nomecliente = Console.ReadLine();
            cliente1.nome = nomecliente;
            Console.WriteLine("inserisci cognome");
            string cognomecliente = Console.ReadLine();
            cliente1.cognome = cognomecliente;
            Menu(cliente1);

        }

        public static void Menu(cliente cliente1)
        {
        Riprova:
            try
            {
                Console.WriteLine("\n");
                Console.WriteLine($" Ciao, {cliente1.nome.ToUpper()} {cliente1.cognome.ToUpper()}!");
                Console.WriteLine("Scegli cosa vuoi ordinare...");
                Console.WriteLine("==============MENU==============");
                Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
                Console.WriteLine("2: Insalata di pollo (€ 5.20)");
                Console.WriteLine("3: Pizza Margherita (€ 10.00)");
                Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
                Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
                Console.WriteLine("6: Insalata di riso (€ 8.00)");
                Console.WriteLine("7: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU==============");

                int sceltaUtente = Convert.ToInt32(Console.ReadLine());

                switch (sceltaUtente)
                {
                    case 1:
                        Console.WriteLine("Hai scelto Coca-Cola (€ 2.50)");
                        cocacola(cliente1);
                        break;
                    case 2:
                        Console.WriteLine("Hai scelto Insalata di pollo (€ 5.20)");
                        Insalatadipollo(cliente1);
                        break;
                    case 3:
                        Console.WriteLine("Hai scelto Pizza Margherita (€ 10.00)");
                        PizzaMargherita(cliente1);
                        break;
                    case 4:
                        Console.WriteLine("Hai scelto  Pizza 4 Formaggi (€ 12.50)");
                        Pizza4Formaggi(cliente1);
                        break;
                    case 5:
                        Console.WriteLine("Hai scelto Pz patatine fritte (€ 3.50)");
                        PatatineFritte(cliente1);
                        break;
                    case 6:
                        Console.WriteLine("Hai scelto  Insalata di riso (€ 8.00)");
                        InsalataDiRiso(cliente1);
                        break;

                    case 7: ContoEEsci(cliente1); break;


                }
            }
            catch
            {
                Console.WriteLine("input non valido.");
                goto Riprova;
            }

        }

        public static void cocacola(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("cocaCola");
            cliente1.CibiOrdinati.Add(2.50f);


            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }

        public static void Insalatadipollo(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("insalata di pollo");
            cliente1.CibiOrdinati.Add(5.20f);

            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }

        public static void PizzaMargherita(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("Pizza MArgherita");
            cliente1.CibiOrdinati.Add(10.00f);

            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }

        public static void Pizza4Formaggi(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("Pizza 4Formaggi");
            cliente1.CibiOrdinati.Add(12.50f);

            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }

        public static void PatatineFritte(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("PatatineFritte");
            cliente1.CibiOrdinati.Add(3.50f);

            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }

        public static void InsalataDiRiso(cliente cliente1)
        {
            cliente1.OrdiniScritti.Add("InsalataDiRiso");
            cliente1.CibiOrdinati.Add(8.00f);
            try
            {
                Console.WriteLine("vuoi ordinare altro? y/n");
                string risposta = Console.ReadLine();

                if (risposta == "y")
                {
                    Menu(cliente1);
                }
                else if (risposta == "n")
                {
                    ContoEEsci(cliente1);
                }

            }
            catch
            {
                Console.WriteLine("input non valido. riprova");
            }
        }


        public static void ContoEEsci(cliente cliente1)
        {
            float totalePrezzo = 0;


            for (int i = 0; i < cliente1.CibiOrdinati.Count; i++)
            {
                float singoloPrezzo = cliente1.CibiOrdinati[i];
                totalePrezzo += singoloPrezzo;


            }
            Console.WriteLine("Hai ordinato: \n");
            for (int i = 0; i < cliente1.OrdiniScritti.Count; i++)
            {

                string CosoOrdinato = cliente1.OrdiniScritti[i];
                Console.WriteLine($"{i + 1}) {CosoOrdinato}");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"IN TOTALE HAI SPESO {totalePrezzo}  Euro");
        }
    }
}
