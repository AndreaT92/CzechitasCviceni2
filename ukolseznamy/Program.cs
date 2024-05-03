// 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

DateTime aktualniCas = DateTime.Now;
Console.WriteLine("Ted je: " + aktualniCas.ToString());


// 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

DateTime datumNarozeni = new DateTime(1992, 1, 25);
Console.WriteLine("Od meho narozeni uplynulo " + (aktualniCas - datumNarozeni).Days + " dnu.");

// 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

List<string> slova = new List<string>() { "pocitac", "klavesnice", "mys", "nabijecka", "kamera" };


// 4. Smaž z tohoto listu libovolnou hodnotu.

slova.Remove("pocitac");

// 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

Console.WriteLine(slova.Contains("lampicka"));

// 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

Console.Write(slova.Count + ": ");
for (int i = 0; i < slova.Count; i++)
{
    Console.Write(slova[i] + ", ");
}
Console.WriteLine();
// 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

Dictionary<string, int> sklad = new Dictionary<string, int>()
{
    { "chleba", 79 },
    { "rohlik", 5 },
    { "kolacek", 35 }
};

// 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
int cena;
if (sklad.TryGetValue("chleba", out cena))
{
    Console.WriteLine($"Cena chleba je: {cena}.");
}
else
{
    Console.WriteLine("Takovou potravinu nemame na sklade.");
}


// 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
sklad["chleba"] = 158;
if (sklad.TryGetValue("chleba", out cena))
{
    Console.WriteLine($"Nova cena chleba je: {cena}.");
}
