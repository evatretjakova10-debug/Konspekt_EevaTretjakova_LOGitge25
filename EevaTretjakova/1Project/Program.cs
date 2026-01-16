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

            //int kasutajaVanus = 0;
            //Console.WriteLine("Kui vana sa oled?");
            //kasutajaVanus = int.Parse(Console.ReadLine());
            //if (kasutajaVanus >= 18)
            //{
            //    Console.WriteLine("Tere, siin on sinu mojito");
            //}
            //else
            //{
            //    Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale.");
            //}


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

            ///* Muutuja nime näide: */
            ///string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud

            // 1   2  3   4  5
            //string näidis = "def"; // 1 - Muutja kirjutatakse alustades andmetüübist,ilma andmetüübita ei saa C# muutujat deklareerida
            //                       // 2 - Seejärel kirjutatkse muutuja nimi mis väljendab andmed ja nende andmete eesmärki nimisõna
            //                       //     soovitavalt kasutada muutujate nimetamisel camelCase stiili. esimene täht on väike, 

            ///**/
            ////String string = "abc"; //is bad
            //string sõna = "abc"; //is good



            //Console.WriteLine("Palun sisesta oma vanus");
            //int kasutajavanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Palun sisesta oma vanaema vanus");
            //int kasutajaVanaemaVanus = int.Parse(Console.ReadLine());
            //int vanusteVahe = kasutajaVanaemaVanus - kasutajavanus;
            //Console.WriteLine("Kui palju sa vanem oled?");
            //kasutajaVanus += int.Parse(Console.ReadLine());
            //Console.WriteLine("vanuste vahe on nüüd: "+(kasutajaVanaemaVanus - kasutajavanus));


            

                /* -= T I N G I M U S L A U S E =-    */
                //if (true)      // Kaitstud sõna "if" kutusub esile tingimuslause, mille tingimuse avaldis on sellele järgnevate () sulgude vahel.
                //{              // Järgneb {} loogiliste sulgude vahel koodiplokke, mis teostatakse siis, kui tingimuse avaldis annab tulemusena "true",
                //               //"false" tulemuse puhul jäetakse kood vahele
                //}
                //else if (true) // Kasutatud sõnad "else" ja "if" (koos "else if") kutsuvad esile sekundaarse tingimuslause, mille tingimus on samamoodi
                //               // sellele järgnevate sulgude vahel, ning millele peab alati eelnema kas "if" või teine "else if". Else if tingimust
                //               // kontrollitakse ainult siis, kui sellele eelnev tingimus tagastab avaldis tulemusena "false".
                //               // Järgneb {} loogiliste sulgude vahel koodiplokk, mis toetatakse siis, kui else if tingimustaluse avaldis annab tulemusena "true",
                //               // false" tulemuse puhul jäetakse kood vahele ning minnakse edasi järgneva tingimuse või teostatava koodi juurde.
                //{
                //else           // Kaitstud sõna "else" kutsub  

                //        using System; //<-- enne nimeruumi, vildatakse selles failis/klassis kasutatud pakettidele/moodulitele ja süsteemi muudele osadele 
                //        //süsteemi muuks osaks võib olla kas operatsioonisüsteemi võimalused või kas ka teised projektid. Teised projektid viidatakse tavaliselt solution (.sln)
                //        //failist.

                        //namespace EsimeneProjekt //<--nimeruum, sisaldab {} sulgude vahel konteinerit kus asub kogu programmi kood nime all "EsimeneProjekt"

                            /*
                             
                        ///* -= S Ü N T A K S =-
                       
                        Console.WriteLine("Ommik");
                        string vastus = Console.ReadLine();
                        Console.WriteLine("C:");
                        // ;        -Iga koodilause koodiploki sees lõppeb lauselõpumärgiga
                        // Console  -Console on windowsi süsteemi/c# käsurea addresserimise pakett, millega saaab erinevasid käsurea operatsioone teha
                        // .        -Kasutatakse adresserimiseks et saada punktide eelnevast objektist mingisugune meetod funktsioon, mis kirjutatakse
                            //      pärast punkti, võib mõelda kui kaustasuunas olevat - släshi. Antud juhul adresseeritakse reas "l" Console tööriista.
                            //()    -Sulupaar mis omab funktsiooni tööks vajalikku infot/parameetreid.
                            //{}    -tähistab koodiplokki konteineri jaoks.
                            //[]    -tähistab massiivi.
                            //""    -tähistavad sõne andmetüüpi andmeid. Andmed ise asuvad jutumärkide vahel.
                            //"string" -andmetüüp mis kitjutatakse alat muutuja ette. andmetüübis endas asuvad ka andmetüübide vajalikud funktsioonid.
                            // "vastus" -muutuja, mille nimi iń "vastus" mis omab string-tüüpi andmeid mis omistatkse sinna sisse omistusopiraatoriga
                            //ReadLine  - Funktsioon mida reas "2" kasutatakse. RedLine loeb käsurea pealt väikeväärtusena sõne-tüüpi andmeid.
                            // //       - Tähistab üherealist kommentaari
    //                      // /**/   //  - Tähistab plokki-kommentaari , kõik tärnide vahel olev on välja kommenteeritud
    //// ///      -Funktsiooni summary kommentaar, kirjeldab meetodeid mille tekst kuvatakse väljatooltpina
    ////      - Taane - aitab areneda aru saada, kuskohas millise koodiplokki sees koood parasjagu asub, ning aitab järge pidada

    //int minuArv = 9001;
    //Console.WriteLine(minuArv);
    //double minuDouble = minuArv;
    //Console.WriteLine(minuDouble);

    //double minuUusDouble = 6.7;
    //Console.WriteLine(minuUusDouble);
    //int minuUusArv = (int)minuUusDouble;
    //Console.WriteLine(minuUusArv);


    /* -= T E I S E N D A M I N E / C A S T I M I N E =-  */

    // Castimine on arvu tesisendamine ühest andmetüübist teise. Castimist on kahte eri liiki, Automaatne (Implicit) ja manuaalne (Explicit)
    //Automaatne castimine toimub siis, kui teisedatakse väiksemast andmetüübist suuremasse, sellisel juhul programmerija spetsiifiliselt
    //castima ei pea.
    //Manuaalne castimine toimub siis, kui teisendatakse suuremast andmetüübist väiksemasse, sellisel juhul on vaja suurema andmetüübiga
    //muutuja ette, asetada sulupaaar kus on soovitav andmetüüb sees.

    /// Manuaalne castimine(Explicit)
    //double newData2 = 1.23d; //tekitakse, või on olemas doubletüüpi andmed muutjas newData2
    //float newFloat2 = (float)newData2; //Toimub teisendus väiksemasse float andmetüüpi, double andetüübist.
    //long newLong2 = (long)newFloatl2; //Toimub eisendus väiksemasse long andmetüüpi, float andmetüübist
    //int newInt2 = (int)newLong2;
    //char newChar2 = (char)newInt2;

    //Automaatne castimine(Impilict)
    //int backToInt2 = newChar2;
    //long backTolONG2 = BackToInt2;
    //float backToFloat2 = backToLong2;
    //double backToDouble2 = backToFloat2;


          /*näieülesanne 7 - "Kalkulaator" */

          Console.WriteLine("Palun sisesta esimene arv");
          float arv1 = 0.0f;
          arv1 = float.Parse(Console.ReadLine());

          Console.WriteLine("Palun sisesta teine arv");
          float arv2 = 0.0f;
          arv2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V");
          string tehteTüüp = "";
          tehteTüüp = Console.ReadLine();

          double tulemus = 0.0d;



            if (tehteTüüp != "")
            {


                switch (tehteTüüp)
                {


                    default:
                        Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                        return;
                    case "+":
                        tulemus = arv1 + arv2;
                      break;
                    case "-":
                        tulemus = arv1 - arv2;
                        break;
                    case "/":
                        tulemus = arv1 / arv2;
                        break;
                    case "*":
                        tulemus = arv1 * arv2;
                        break;
                    case "^":
                        tulemus = Math.Pow(arv1, arv2);
                        break;
                    case "V":
                        tulemus = Math.Pow(arv1, (1 / arv2));
                        break;
                }
                Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tulemus}");

            }
            else
            {
                Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritada.");
            }
                
        }





  








//    Console.WriteLine("Palun sisesta oma vanus, kirjuta täisvanus: ");
//    int isiskuVanus = 0;
//    isikuVanus = int.Parse(Console.ReadLine());
//            if (isiskuVanus <= 0)
//            {
//                Console.WriteLine("Ajarändureid me ei teeninda");
//            }
//            else if (isikuVanus > 0 && isikuVanus< 18)
//            {
//                Console.WriteLine("Palun sisesta oma nimi:");
//                string kasutajaNimi = "";
//    kasutajaNimi = Console.ReadLine();
//                Console.WriteLine($"Kallis (kasutajaNimi), palun kutsu siia oma lapsevanema");
//            }
//            else
//{
//    Console.WriteLine("Palun kirjuta siia oma Eesnimi:");
//    string eesNimi = "";
//    eesNimi = Console.ReadLine();
//    Console.WriteLine("Palun kirjuta siia oma Perekonnanimi:");
//    string perekonnaNimi = "";
//    perekonnaNimi = Console.ReadLine();
//    if (eesNimi == perekonnaNimi == "")
//    {
//        Console.WriteLine("Sisestama pidi mõlemad nimed >:C");
//    }
//    else
//    {
//        Console.WrteLine($"Tere päevast (eesNimi) ("perekonnaNimi);
//    }

}

               
            }