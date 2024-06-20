//Denne appen skal gi en oversikt over hvilke butikker som finnes, hva som er spesialiteten deres (klær, matvarer, leker etc) 
//og prisnivået varene ligger på (1= billig 2=midt på treet 3=sinnsykt dyrt)
//Man skal også kunne legge til nye butikker, og få mulighet til å velge å se en liste over alle butikker, 
//    velge å se kun de billigste, velge å se kun de som er midt på treet prismessig eller velge å se bare de butikkene som er rangert som sinnsykt dyre.
//BONUS
//Gjør så man også kan sortere/velge å se butikker som har en viss spesialitet f.eks klær i tillegg til å kunne sortere på pris. 
//    Kjekt å se hvor man kan kjøpe billig mat og dyre designer klær, hehe;)


// Klass butikk!
//Type butikk i objekter (Liste av butikker)
//Liste av prisnivåer
//Kunne se alle butikkene
//Legge til ny butikk
//Sortere butikkene


using ButikkPP;

Shops shop = new Shops();
List<Shops> allShops = new List<Shops>()
{
    new Shops("Meny", "GrocerieShop", 2),
    new Shops("Joker", "GrocerieShop", 3),
    new Shops("Rema 1000", "grocerieShop", 1),
    new Shops("Elkjøp", "electronic shop", 2),
    new Shops("Power", "electronic shop", 3),
    new Shops("Komplett", "Electronic shop", 1),
};


Main();

void Main()
{
    while (true)
    {
        Console.WriteLine("Welcome to the shops app!");
        Console.WriteLine("\t Here are some options:");

        MainMenu();

    }
}


void MainMenu()
{
    Console.Clear();
    Console.WriteLine("\n\t1. See all shops");
    Console.WriteLine("\t2. Check prizes");
    Console.WriteLine("\t3. Add a new shop");
    Console.WriteLine("\t4. Close");
    
    var MainResponse = Console.ReadKey().KeyChar;
    switch (MainResponse)
    {
        case '1':
            shop.ShopMenu(allShops);
            break;
        case '2':
            shop.SortingMethod(allShops);
            break;
        case '3':
            break;
        case '4':
            Console.Clear();
            Console.WriteLine("Closing the app!");
            Thread.Sleep(2000);
            Environment.Exit(404);
            break;
        default:
            Console.WriteLine("please input one of the options above!");
            break;
    }




}





















