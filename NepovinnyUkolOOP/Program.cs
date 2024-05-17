namespace NepovinnyUkolOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BREAKOUT ROOM 2
            /* Vyuzij tridu Obdelnik z prvniho BR.
               Prepis fieldy Sirka a Vyska na properties.
               Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.  
               Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
               Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
               Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
               Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
               Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
            */

            Obdelnik obdelnik = new Obdelnik(4, 5);
            obdelnik.Vypis();
            obdelnik.Zvetsi(2, 3);
            obdelnik.Vypis();
            Obdelnik nulovyObdelnik = new Obdelnik(0, 0);
            nulovyObdelnik.Vypis();

        }
    }
}
