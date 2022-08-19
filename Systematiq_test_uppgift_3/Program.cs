using Systematiq_test_uppgift_3;


var sifror_1_25 = Listor.Tal_1_till_25;

List<int> sorteradLista = Listor.OrdnaEfterNummernamn(sifror_1_25);


List<string> tabell = new();
Console.WriteLine("Bokstav Sorterad\tBokstav Osorterad\n");

for (int i = 0; i < sifror_1_25.Count; i++)
{
    Console.WriteLine(sorteradLista[i] + "\t\t\t" + sifror_1_25[i]);
}