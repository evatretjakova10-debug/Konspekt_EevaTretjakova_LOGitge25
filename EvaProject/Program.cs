using System.ComponentModel.Design;
using System.Linq;

namespace EsimeneProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* näiteprogramm 1*/
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles."); // print(kontojääk + " puuehte on alles")
            //Console.WriteLine("Palun sisesta oma hästi tehtud töö boonus: ");
            //int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("Palun sisesta oma hästi tehtud töö boonus: "))
            //kontojääk = kontojääk + boonus; // same python
            //Console.WriteLine("Sinu lõppväljavõte on: " + kontojääk + " puulehte");

            /* näiteprogramm 2 */
            /*
             * klient tahab et programm teeks: 
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */

            //int kasutajaVanus = 0;
            //Console.WriteLine("Kui vana sa oled?");
            //kasutajaVanus = int.Parse(Console.ReadLine());
            //if (kasutajaVanus >= 18)
            //{
            //    Console.WriteLine("Tere, siin on sinu mojito 🍹");
            //}
            //else
            //{
            //    Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 🤡");
            //}

            ///*
            // näiteprogramm 3:

            //klient tahab et programm teeks:
            // - küsib kasutajalt tema kasutajaNime
            // - küsib kasutajalt tema parooli
            // - logib kasutaja sisse kui mõlemad on õiged
            // */
            // hint: mida teeb &&?

            /* siia käib vooskeemi järgi kirjutatud kood näidisülesanne 3 kohta */

            ////ctrl + k + c/u

            ///*   -= L I H T A N D M E T Ü Ü B I D =-             */
            //string tekst = "mingisugune inimloetav tekstike"; //tekst
            //char täht = 'A';
            //int arv = 1; //täisarv
            //float komakohagaarv = 1.5f; //32bit
            //double suuremkomakohagaarv = 1.5d; //64bit
            //decimal kümnendsüsteemiskomakohagaarv = 1.5M;
            //var x = 123; //Umbmäärase andmetüübiga ajutine muutuja
            //var y = "ABC";
            //bool jahvõiei = false; //kas true või false.

            ///**/
            ////string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud

            //Console.WriteLine("Palun sisesta oma vanus");
            //int kasutajavanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Palun sisesta oma vanaema vanus");
            //int kasutajaVanaemaVanus = int.Parse(Console.ReadLine());
            //int vanusteVahe = kasutajaVanaemaVanus - kasutajavanus;
            //Console.WriteLine(kasutajaVanaemaVanus - kasutajavanus);
            //Console.WriteLine("Kui palju sa vanem oled?");
            //kasutajavanus += int.Parse(Console.ReadLine());
            //Console.WriteLine("vanuste vahe on nüüd: " + (kasutajaVanaemaVanus - kasutajavanus));

            ///* -= O M I S T U S O P E R A T O O R =-       */
            ////=   ->üksik võrdusmärk omistab muutja sisse väärtuse, mida adesseeritakse muutuja enda nimega
            //int muutuja = 1;
            //// +=   -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            //muutuja += 2;
            ////-= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva värtuse
            //muutuja -= 1;
            //// *=  -> võrdusmärk mille ees on 

            //muutuja *= 3;
            ////*     -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            //muutuja %

            /* näiteülesanne 5 */

            Console.WriteLine("Kui kaugele oli su viimane koolitõuge (m)?");
            float kaugus = float.Parse(Console.ReadLine());
            if (kaugus <= 1.00 && kaugus >= 0.00)
            {
                Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            }
            else if (kaugus <= 2.00 || kaugus >= 1.01)
            {
                Console.WriteLine("Noh tuleb juba, jõuad veel!");
            }
            else if (kaugus <= 3.00 && kaugus >= 2.01 )
            {
                Console.WriteLine("Tubli kolm meetrit umbes, peaaegu, vist...not sure");
            }
            else if (kaugus < 0)
            {
                Console.WriteLine("´MIKS SA TAGURPIDI VISKAD!?");
            }
            else
            {
                Console.WriteLine("Ossaraks seda on varsti arbiitilt näha");
            }
            Console.WriteLine("Palun sisesta oma vanus");
            int kasutajavanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisesta oma vanaema vanus");
            int kasutajaVanaemaVanus = int.Parse(Console.ReadLine());
            int vanuseVahe = kasutajaVanaemaVanus - kasutajaVanus;
            Console.WriteLine(kasutajavaanemaVanus - kasuatajaVanus);

            /* näiteülesanne 8 */
            //kirjuta programm mis
            //küsib kasutajatelt pikkust *sentimeetrites* 
            //küsib tema teiste perekonnaliikmete pikkust (ema isa vend)
            // programm arvutab välja perekonna keskmise pikkuse, vanemate keskmise pikkuse, laste keskmise pikkuse ja kahe keskmise vahe,
            // kõik arvud peab programm esitama komakohtadega arvudena
            int kasutajapikkus = 0;
            int vennapikkus = 0;
            int emapikkus = 0;
            int isapikkus = 0;
            List<int> vanused = new List<int>();
            List<string> isikud = new List<string>() { "sinu", "oma venna", "oma isa", "oma ema" };
            int i = 0;
            do
            {
                Console.WriteLine("Sisesta " + isikud " pikkus sentimeetrites");
                //kuvame kasutajatele teate, koos isikuga mida adresseeritakse tsükklimuutuja abil järjendist "isikud"
                vanused.Add(int.Parse(Console.ReadLine()));
                //.Add on Listsi meetod elemendi lisamiseks, lisatakse otse parsitud täisarv käsurea pealt
                i++;
                //suurendame i-d ühe võrra
            } while (i < 4);
            Console.WriteLine("Mis sinu pikkus sentimeetrites?: ");
            kasutajapikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis sinu venna pikkus sentimeetrites?: ");
            vennapikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis sinu ema pikkus sentimeetrites?: ");
            emapikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis sinu isa pikkus sentimeetrites?: ");
            isapikkus = int.Parse(Console.ReadLine());
            float perekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(3) + vanused.ElementAt(3) + vanused.ElementAt(1) + vanused.ELementAt(2)) / 4) / 100;

            float lastekeskmine = ((float)() / 2) / 100;
            float vanematekeskmine = ((float)(emapikkus + isapikkus) / 2) / 100;
            float vahe = 0;
            if (vanematekeskmine > lastekeskmine)
            {
                vahe = vanematekeskmine - lastekeskmine;
            }
            else
            {
                vahe = lastekeskmine - vanematekeskmine;
            }
            Console.WriteLine("perekeskmine on " + Math.Round(perekeskmine, 2) + "m. vanematekeskmine on " + Math.Round(vanematekeskmine, 2) + "m.\nlastekeksmine on " + Math.Round(lastekeskmine, 2) + "m. kahe keskmise vahe on " + Math.Round(vahe, 2) + "m.");

            /* -= T S Ü K L I D =-

            //Tsüklid on programemerimise viis, kuidas automaatiseerida korduv tegevus ära, see aitab hoida andmemahtu kokku, programmerija sama
            // koodi mitu korda kirjutamisest, ning väldib ka kordustest tekkinud vigu. C# on neli peamist tsükli liiki -
            //1. do-white
            //2. while
            //3.for
            //4. foreach

        /*  -= T S Ü K L I D  DO-WHILE=-         */

            //Do-White tsükkel erineb kõigist tsükklitest sellega, et tingimuskontroll toimub pärast esimest tegevusringi. Kõikides
            // teistes tsüklites toimub tingimusekomtroll enne esimest ringi.

            int tsükliMuutuja = 0;                //Mingisuguse muutuja, mis omab tsükli töö tingimuse abil kontrollimiseks vajalikku väärtust
                                                  //ehk tsüklimuutuja 
            do                                    //"do" on kaitstud sõna, mis alustab do white tsüklit, Sellele järgneb tsüklis tehtav koodiplokk
                                                  //ning mis esimene ring täidetakse ilma tingimuse kontroolita.
            {
                Console.WriteLine(tsükliMuutujal); //Kooodiploki sees ólev tegevus, antud juhul kuvatakse tsüklimuutuja muutuja arv välja 
                tsükliMuutjal++;                   //ning tsüklimuutujat suurendatakse.
                //ILMA TSÜKLIMUUTUJA KAASAMISETA TSÜKLI TÖÖSSE, KÄIB TSÜKKEL RINGI LÕPMATULT, TSÜKLIMUUTUJA TULEB MINIGL KUJUL KAS KAUDSELT VÕI
                //OTSESELT, ET SÜSTEEM SAAKS EDASI TEISTE TEGEVUSTE JUURDE MINNA, ILMA SELLETA SEE EI OLE VÕIMALLIK. 
            } while (tsükliMuutjal != 5);   //"While" on kaitstud sõna mis do-while tsükli lõpetab, pärast seda toimub esimene tingimuse
                                            //kontroll, kus kontrollitakse tsükli tössa


            string sõnum = sring.Empty;
            do
            {
                Console.WriteLine("palun lisa sõnumi järgmine osa"):
                string sisestus = string.Empty;
                sisestus = Console.ReadLine();
                sõnum += sisestus;
                Console.WriteLine(sõnum);

            } while (sõnum.Lnegth <= 140);
            Console.WriteLine("see sõnum enam ttwitterisse ei mahuks, kirjuta vähem fam");
        } 
    } 
}