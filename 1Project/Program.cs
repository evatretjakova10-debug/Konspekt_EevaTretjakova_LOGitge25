using System.Runtime.CompilerServices;

namespace _1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli?");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLne("Sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //Console.Writeline(kontojääk + " puulehte on alles."); // print(kontojääk + " puulehte on alles")
            //Console.Writeline("palun sisesta oma hästi tehtud töö boonus ");
            //int boonus = int.parse(console.readline());// boonus = int(input("palun sisesta oma hästi tehtud töö boonus"))
            //kontojääk = kontojääk + boonus; // same python
            //Console.Writeline("Sinu lõppväljavõte on: " + kontojääk + " puulehte");

            /*
             * 
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi 
               sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */

            int kasutajaVanus = 0;
            Console.WriteLine("Kui vana sa oled?");
            kasutajaVanus = int.Parse(Console.ReadLine());
            if (kasutajaVanus >= 18)
            {
                Console.WriteLine("Tere, siin on sinu mojito");
            }
            else
            {
                Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale.");
            }


            ///* +=L I H T A N D M E T Ü Ü B I D =-    */
            //string tekst = "tekst";
            //char täht = `A`;
            //int arv = 1; //täisarv
            //float komakohagaarv = 1.5f; //32bit
            //double suurekohagaarv = 1.5d; //64bit
            //decimal kümendsüsteemiskomakohagaarv = 1.5M;
            //var X = 123; //Umbäärase andmetüübiga ajutine muutja
            //var y = "ABC"
            //bool jahvõiei = false; //kas true või false


            ///**/
            ////String string = "abc"; //is bad
            //string sõna = "abc"; //is good
        }
    }
}
