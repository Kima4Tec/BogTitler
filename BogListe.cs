using System;
using System.Collections.Generic;

namespace BogTitler
{
    public class BogListe    
    {
        public static void BogListen() { 

        List<IBog> bogliste = new List<IBog>();
        bogliste.Add(item: new Bog()
        {
            Id = 1,
            Emne = BogEmne.programmering.ToString(),
            Forfatter = "Michel Cronberg",
            Genre = BogGenre.non_fiktion.ToString(),
            Titel = "Bogen om C#"
        });;
            bogliste.Add(item: new Bog()
            {
                Id = 2,
                Emne = BogEmne.dokumentar.ToString(),
                Forfatter = "Cecilie Frøkjær",
                Genre = BogGenre.non_fiktion.ToString(),
                Titel = "Lys i livet, Cecilie Frøkjær interviewer Jane Aamund"
            });


            foreach (var item in bogliste)
            {

                Console.WriteLine($"{item.Forfatter}\n {item.Titel}\n {item.Emne}\n {item.Genre}\n\n");
            }
        }

    }
}
