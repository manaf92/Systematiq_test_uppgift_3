using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systematiq_test_uppgift_3
{
    public class Listor
    {
        public static List<int> Tal_1_till_25 { get; set; } = new()
        {
           1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25  
        };
        public static List<string> Talnamn_1_till_25 { get; set; } = new()
        {
            "ett","två","tre","fyra","fem","sex","sju","åtta","nio","tio",
            "elva","tolv","treton","fjorton","femton","sexton","sjutton","arton","niton","tjugo",
            "tjugoett","tjugotvå","tjugotre","tjugofyra","tjugofem"
        };

        public static List<int> OrdnaEfterNummernamn(List<int> tal)
        {
            List<string> talNamn = new();
            tal.ForEach(t => talNamn.Add(Talnamn_1_till_25.ElementAt(t - 1)));
            var bokstavSorteradLista = talNamn.OrderBy(x => x).ToList();
            
            //nytt lista inholler sifror efter sortering
            List<int> nyttSorteradTal = new(); ;
            bokstavSorteradLista.ForEach(n => nyttSorteradTal.Add(Talnamn_1_till_25.IndexOf(n) + 1));
            return nyttSorteradTal;
        }
    }
}
