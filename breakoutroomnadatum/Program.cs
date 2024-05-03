Console.WriteLine("Zadejte den:");
string textDen = Console.ReadLine();
int den = int.Parse(textDen);

Console.WriteLine("Zadejte mesic:");
string textMesic = Console.ReadLine();
int mesic = int.Parse(textMesic);


Console.WriteLine("Zadejte rok:");
string textRok = Console.ReadLine();
int rok = int.Parse(textRok);

DateTime ted = DateTime.Now;
DateTime casDovoleny = new DateTime(rok, mesic, den);
TimeSpan casDoDovoleny = ted - casDovoleny;
Console.WriteLine($" Dny: {casDoDovoleny.Days} Hodiny: {casDoDovoleny.Hours}");