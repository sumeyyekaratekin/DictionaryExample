using System;
using System.Collections.Generic;

namespace MyDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cities and phone number in Turkey 
            MyDictionary<string, int> cities = new MyDictionary<string, int>();

            cities.Add("Adana",322);
            cities.Add("Adıyaman",416);
            cities.Add("Afyon",272);
            cities.Add("Ağrı",472);
            cities.Add("Aksaray",382);
            cities.Add("Amasya",358);
            cities.Add("Ankara",312);
            cities.Add("Antalya",242);
            cities.Add("Ardahan",478);
            cities.Add("Artvin",466);
            cities.Add("Aydın",256);
            cities.Add("Balıkesir",266);
            cities.Add("Bartın",378);
            cities.Add("Batman",488);
            cities.Add("Bayburt",458);
            cities.Add("Bilecik",228);
            cities.Add("Bingöl",426);
            cities.Add("Bitlis",434);
            cities.Add("Bolu",374);
            cities.Add("Burdur",248);
            cities.Add("Bursa",224);
            cities.Add("Çanakkale",286);
            cities.Add("Çankırı",376);
            cities.Add("Çorum",364);
            cities.Add("Denizli",258);
            cities.Add("Diyarbakır",412);
            cities.Add("Düzce",380);
            cities.Add("Edirne",284);
            cities.Add("Elazığ",424);
            cities.Add("Erzincan",446);
            cities.Add("Erzurum",442);
            cities.Add("Eskişehir",222);
            cities.Add("Gaziantep",342);
            cities.Add("Giresun",454);
            cities.Add("Gümüşhane",456);
            cities.Add("Hakkari",438);
            cities.Add("Hatay",326);
            cities.Add("Iğdır",476);
            cities.Add("Isparta",246);
            cities.Add("İçel(Mersin)", 324);
            cities.Add("İstanbul(Anadolu Yakası)",216);
            cities.Add("İstanbul(Avrupa Yakası)",212);
            cities.Add("İzmir",232);
            cities.Add("Kahramanmaraş",344);
            cities.Add("Karabük",370);
            cities.Add("Karaman",338);
            cities.Add("Kars",474);
            cities.Add("Kastamonu",366);
            cities.Add("Kayseri",352);
            cities.Add("Kırıkkale",318);
            cities.Add("Kırklareli",288);
            cities.Add("Kırşehir",386);
            cities.Add("Kilis",348);
            cities.Add("Kocaeli",262);
            cities.Add("Konya",332);
            cities.Add("Kütahya",274);
            cities.Add("Malatya",422);
            cities.Add("Manisa",236);
            cities.Add("Mardin",482);
            cities.Add("Muğla",252);
            cities.Add("Muş",436);
            cities.Add("Nevşehir",384);
            cities.Add("Niğde",388);
            cities.Add("Ordu",452); 
            cities.Add("Osmaniye",328);
            cities.Add("Rize",464);
            cities.Add("Sakarya",264);
            cities.Add("Samsun",362);
            cities.Add("Siirt",484);
            cities.Add("Sinop",368);
            cities.Add("Sivas",346);
            cities.Add("Şanlıurfa", 414);
            cities.Add("Şırnak",486);
            cities.Add("Tekirdağ",282);
            cities.Add("Tokat",356);
            cities.Add("Trabzon",462);
            cities.Add("Tunceli",428);
            cities.Add("Uşak",276);
            cities.Add("Van",432);
            cities.Add("Yalova",226);
            cities.Add("Yozgat",354);
            cities.Add("Zonguldak",372);


            foreach (var city in cities.Items)
            {
                Console.WriteLine("City : " + city.Item1 +  "\tPhone Code : (0 " + city.Item2+")");
            }

            Console.WriteLine("Total number of phone codes: "+cities.Items.Length);
        }
    }
}
