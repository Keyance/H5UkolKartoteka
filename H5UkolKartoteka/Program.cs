var kartoteka = new Dictionary<string, string>();

kartoteka.Add("Tera Dostalíková", "1999");
kartoteka.Add("Radek Pavel", "1985");
kartoteka.Add("Nela Nechtěná", "1995");

bool jeKonec = false;

while (!jeKonec)
{
    Console.WriteLine("1 - přidat osobu");
    Console.WriteLine("2 - smazat osobu");
    Console.WriteLine("3 - Vypsat osoby");
    Console.WriteLine("4 - Hledat záznam dle začátku jména");
    Console.WriteLine("0 - Konec");

    int volba = Convert.ToInt32(Console.ReadLine());

    switch (volba)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            {
                Console.WriteLine("Zadej křestní jméno:");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadej příjmení:");
                string prijmeni = Console.ReadLine();
                string celeJmeno = jmeno + " " + prijmeni;
                Console.WriteLine("Zadej rok narození:");
                string rokNarozeni = Console.ReadLine();
                kartoteka.Add(celeJmeno, rokNarozeni);
                break;
            }
        case 2:
            {
                Console.WriteLine("Zadej jméno (křestní i příjmení) osoby, kterou chceš smazat:");
                string jmeno = Console.ReadLine();
                if (kartoteka.Remove(jmeno))
                {
                    Console.WriteLine("Položka byla smazána.");
                } else { Console.WriteLine("položka nebyla nalezena."); }
                break;
            }
        case 3:
            int i = 0;
            foreach (var o in kartoteka)
            {
                Console.WriteLine($"{i}\t{o.Key}\t{o.Value}");
                i++;
            }
            break;
        case 4:
            {
                Console.WriteLine("Zadej počátek hledané osoby:");
                string pocatek = Console.ReadLine();
                var jmeno = kartoteka.Where(x => x.Key.StartsWith(pocatek)).Select(z => z.Value).ToList();
                foreach (var jm in jmeno)
                {
                    Console.WriteLine(jm);
                }
            }
            break;
    }
}