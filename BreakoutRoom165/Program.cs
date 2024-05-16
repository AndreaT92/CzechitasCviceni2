namespace BreakoutRoom165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            obdelnik obdelik1 = new obdelnik(5, 6);
            obdelnik ctverec = new obdelnik(5);
            
            obdelik1.Vypis();
            ctverec.Vypis();
        }
    }
}
