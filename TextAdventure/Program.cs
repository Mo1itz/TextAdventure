using TextAdventure;

string Nahrungssuche = "Nahrungssuche";
string Jo = "Jo";
string Ja = "Ja";
string Messer = "Messer";
bool gameOver = false;
bool Gewonnen = false;

string Ort = "Gegenstandsauswahl";
string? Sache1, Sache2, Sache3;


var startseite = new Startseite();
Ort = startseite.Execute();
startseite = new Startseite();


do
{
    switch (Ort)
    {
        case "Gegenstandsauswahl":
            Gegenstandsauswahl();
            break;
        case "Messernachfrage":
            Messerfrage();
            break;
        case "E1":
            E1();
            break;
        case "Tod":
            Tod();
            break;
        case "E2":
            E2();
            break;
        case "E3":
            E3();
            break;
        case "E4":
            E4();
            break;
        case "E5":
            E5();
            break;
        case "E6":
            E6();
            break;
        case "E7":
            E7();
            break;
        
    }
}
while (!gameOver  && ! Gewonnen);

if(gameOver)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("GAME OVER");

}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Du hast gewonnen!");

}





void Messerfrage()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Sicher, ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" dass ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" du ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" kein ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" Messer ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" mitnehmen ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(" möchtest?");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.White;
    string? Antwort = Console.ReadLine();
    if (Antwort == Ja || Antwort == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Dann ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" bin ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" ich ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("gespannt, ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" ob ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" du ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" überleben ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" wirst");
        Thread.Sleep(100);



        Ort = "E1";
    }
    else if (Antwort == "Nein")
    {
        Ort = "Gegenstandsauswahl";
    }
}

void E1()
{
    
    


    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Als ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" nächstes ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" musst ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("du ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" dich ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" entscheiden, ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" ob ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" du");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" dich");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("zuerst ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" um ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" die ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Nahrungssuche ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" oder ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" um");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" eine ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" Unterkunft ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" kümmern ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(" wirst");
    Thread.Sleep(100);


    Console.ForegroundColor = ConsoleColor.Green;
    string? E1 = Console.ReadLine();

    if (E1 == Nahrungssuche)
    {
        

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Du ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("hättest ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" dich ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" zuerst ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("mit ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" der ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" Unterkunft ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" ausseinandersetzen ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" sollen,");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" da ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("ein");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" starkes ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" Unwetter ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("aufzieht. ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" Aufgrund ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" dessen,");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" das ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" du ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" kein ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" Schutz");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" hast, ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" wirst ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" du");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" von ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" einem ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" Blitz");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" getroffen ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" und ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" bist");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" Tod ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" wirst");
        Thread.Sleep(100);




        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("    ___(                        )");
        Console.WriteLine("   (                          _)");
        Console.WriteLine("  (_                       __))");
        Console.WriteLine("    ((                _____)");
        Console.WriteLine("      (_________)----'");
        Console.WriteLine("         _/  /");
        Console.WriteLine("        /  _/");
        Console.WriteLine("      _/  /");
        Console.WriteLine("     / __/");
        Console.WriteLine("   _/ /");
        Console.WriteLine("  /__/");
        Console.WriteLine(" //");
        Console.WriteLine("/'");
        Ort = "Tod";
    }
    else if (E1 == "Unterkunft")
    {
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" Du, ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" hast ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" die");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" richtige ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" Entscheidung ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" getroffen,");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" da ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" ein ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" starkes");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" Unwetter ");
        Thread.Sleep(100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" aufzieht");
        Thread.Sleep(100);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("        ------               _____");
        Console.WriteLine("       /      \\ ___\\     ___/    ___");
        Console.WriteLine("    --/-  ___  /    \\/  /  /    /   \\");
        Console.WriteLine("   /     /           \\__     //_     \\");
        Console.WriteLine("  /                     \\   / ___     |");
        Console.WriteLine("  |           ___       \\/+--/        /");
        Console.WriteLine("   \\__           \\       \\           /");
        Console.WriteLine("      \\__                 |          /     ");
        Console.WriteLine("     \\     /____      /  /       |   /         ");
        Console.WriteLine("      _____/         ___       \\/  /\\        ");
        Console.WriteLine("           \\__      /      /    |    |      ");
        Console.WriteLine("         /    \\____/   \\       /   //                                 ");
        Console.WriteLine("     // / / // / /\\    /-_-/\\//-__-                 ");
        Console.WriteLine("      /  /  // /   \\__// / / /  //");
        Console.WriteLine("     //   / /   //   /  // / // /");
        Console.WriteLine("      /// // / /   /  //  / //");
        Console.WriteLine("   //   //       //  /  // / /");
        Console.WriteLine("     / / / / /     /  /    /");
        Console.WriteLine("  ///  / / /  //  // /  // //");
        Console.WriteLine("     ///    /    /    / / / /");
        Console.WriteLine("///  /    // / /  // / / /  /");
        Console.WriteLine("   // ///   /      /// / /");
        Ort = "E2";
    }
}

void E2()
{
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" Nachdem ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("das");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" Unweter ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" vorbei ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("gezogen. ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" ist, ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" gehst,");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" du ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" auf ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" die ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" Suche");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" nach, ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" Nahrung ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" und");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" siehst ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" eine ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" dir");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" unbekannte ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" Fruht. ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" ist");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" du ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" sie?");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("  \\");
    Console.WriteLine(" ()()");
    Console.WriteLine("()()()");
    Console.WriteLine(" ()()");
    Console.WriteLine("  ()");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E3 = Console.ReadLine();
    if (E3 == Ja || E3 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Dann hast du Glück gehabt, die Frucht war nicht giftig");
        Ort = "E4";
    }
    else if (E3 == "Nein")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Dann musst du weiter suchen");
        Ort = "E3";
    }
}

void E3()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Möchtest du dich auf die Lauer legen und versuchen ein Tier zu erlegen?");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E5 = Console.ReadLine();
    if (E5 == Ja || E5 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Dann liegst du jz auf der Lauer");
        Ort = "E5";
    }
    else if (E5 == "Nein")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Dann verhungerst du");
        Ort = "Tod";
    }
}

void E4()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Super, du hast bis jetzt alles richtig gemacht. Nun baust du dir ein Floß aus Palmen. Einige Zeit später ist das Floß fertig gebaut, jedoch als du losfahren möchtest siehst du eine dunkle Wolke am Himmel. Möchtest du trotzdem fahren?");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                                        ___    ,'\"\"\"\"'.");
    Console.WriteLine("                                    ,\"\"\"   \"\"\"\"'      `.");
    Console.WriteLine("                                   ,'        _.         `._");
    Console.WriteLine("                                  ,'       ,'              `\"\"\"'.");
    Console.WriteLine("                                 ,'    .-\"\"`.    ,-'            `.");
    Console.WriteLine("                                ,'    (        ,'                :");
    Console.WriteLine("                              ,'     ,'           __,            `.");
    Console.WriteLine("                        ,\"\"\"\"'     .' ;-.    ,  ,'  \\             `\"\"\"\".");
    Console.WriteLine("                      ,'           `-(   `._(_,'     )_                `.");
    Console.WriteLine("                     ,'         ,---. \\ @ ;   \\ @ _,'                   `.");
    Console.WriteLine("                ,-\"\"'         ,'      ,--'-    `;'                       `.");
    Console.WriteLine("               ,'            ,'      (      `. ,'                          `.");
    Console.WriteLine("               ;            ,'        \\    _,','                            `.");
    Console.WriteLine("              ,'            ;          `--'  ,'                              `.");
    Console.WriteLine("             ,'             ;          __    (                    ,           `.");
    Console.WriteLine("             ;              `____...  `      `.                  ,'           ,'");
    Console.WriteLine("             ;    ...----'''' )  _.-  .       `.                ,'    ,'    ,'");
    Console.WriteLine("_....----''' '.        _..--\"_.-:.-' .'        `.             , ''.   , ' `--'");
    Console.WriteLine("              `\"     \"\" _.- ''.- '`-.:..___...--' `-._, -\"'   `-'");
    Console.WriteLine("        _.--'       _.-'    .'   .' .'               `\"\"\"\"\"");
    Console.WriteLine("  __.-''        _.-'     .-'   .'  /");
    Console.WriteLine(" '          _.-' .-'  .-'        .'");
    Console.WriteLine("        _.-'  .-'  .-' .'  .'   /");
    Console.WriteLine("    _.-'      .-'   .-'  .'   .'");
    Console.WriteLine("_.-'       .-'    .'   .'    /");
    Console.WriteLine("       _.-'    .-'   .'    .'");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E6 = Console.ReadLine();
    if (E6 == Ja || E6 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Schade, das wars mit dir, da dein Floß bei dem unwetter mitten auf dem Meer von einem Blitz getroffen wurde");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("    ___(                        )");
        Console.WriteLine("   (                          _)");
        Console.WriteLine("  (_                       __))");
        Console.WriteLine("    ((                _____)");
        Console.WriteLine("      (_________)----'");
        Console.WriteLine("         _/  /");
        Console.WriteLine("        /  _/");
        Console.WriteLine("      _/  /");
        Console.WriteLine("     / __/");
        Console.WriteLine("   _/ /");
        Console.WriteLine("  /__/");
        Console.WriteLine(" //");
        Console.WriteLine("/'");
        Ort = "Tod";
    }
    else if (E6 == "Nein")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Gute Entscheidung. Du fährst einen Tag später los.");
        Ort = "E6";
    }


}

void E5()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Vor dir läuft dieser Affe, möchtest du ihn töten?");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("                __------__");
    Console.WriteLine("              /~          ~\\");
    Console.WriteLine("             |    //^\\\\//^\\|");
    Console.WriteLine("           /~~\\  ||  o| |o|:~\\");
    Console.WriteLine("          | |6   ||___|_|_||:|");
    Console.WriteLine("           \\__.  /      o  \\/'");
    Console.WriteLine("            |   (       O   )");
    Console.WriteLine("   /~~~~\\    `\\  \\         /");
    Console.WriteLine("  | |~~\\ |     )  ~------~`\\");
    Console.WriteLine(" /' |  | |   /     ____ /~~~)\\");
    Console.WriteLine("(_/'   | | |     /'    |    ( |");
    Console.WriteLine("       | | |     \\    /   __)/ \\");
    Console.WriteLine("       \\  \\ \\      \\/    /' \\   `\\");
    Console.WriteLine("         \\  \\|\\        /   | |\\___|");
    Console.WriteLine("           \\ |  \\____/     | |");
    Console.WriteLine("           /^~>  \\        _/ <");
    Console.WriteLine("          |  |         \\       \\");
    Console.WriteLine("          |  | \\        \\        \\");
    Console.WriteLine("          -^-\\  \\       |        )");
    Console.WriteLine("               `\\_______/^\\______/");





    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string ? E6 = Console.ReadLine();
if (E6 == Ja || E6 == Jo)
{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Während du versuchst den Affen zu töten, kommen hunderte von Affen zur Unterstützung und töten dich");
    Ort = "Tod";
}
else if (E6 == "Nein")
{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Währed du auf der Lauer liegst kommt dieser Skopion von hinten und sticht dich");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ___    ___");
        Console.WriteLine("( _<    >_ )");
        Console.WriteLine("//        \\\\");
        Console.WriteLine("\\\\___..___//");
        Console.WriteLine(" `-(    )-'");
        Console.WriteLine("   _|__|_");
        Console.WriteLine("  /_|__|_\\");
        Console.WriteLine("  /_|__|_\\");
        Console.WriteLine("  /_\\__/_\\");
        Console.WriteLine("   \\ || /  _)");
        Console.WriteLine("     ||   ( )");
        Console.WriteLine("     \\\\___//");
        Console.WriteLine("      `---'");
        Ort = "Tod";
}
}

void E6()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Als du auf dem offenem Meer bist, siest du in 100 Meter entfernung ein sinkendes schiff. Paddelst du gegen die Strömung an, um zu helfen oder lässt du dich weiter zum Festland treiben? wählst du Option 1 oder 2 ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("              |    |    |");
    Console.WriteLine("             )_)  )_)  )_)");
    Console.WriteLine("            )___))___))___)\\");
    Console.WriteLine("           )____)____)_____)\\\\");
    Console.WriteLine("         _____|____|____|____\\\\\\__");
    Console.WriteLine("---------\\                   /---------");
    Console.WriteLine("  ^^^^^ ^^^^^^^^^^^^^^^^^^^^^");
    Console.WriteLine("    ^^^^      ^^^^     ^^^    ^^");
    Console.WriteLine("         ^^^^      ^^^");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E7 = Console.ReadLine();
    if (E7 == "1")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Du bist sehr hilfsbereit, jedoch ist die Strömung zu stark und du schaffst es nicht.");
        Ort = "E7";
    }
    else if (E7 == "2")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Du bist nicht sehr hilfsbereit aber es war die bessere Entscheidung, da du nicht gegen die Strömung angekommen wärst");
        Ort = "E7";
    }
}

void Tod()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("GAME OVER");
    Ort = startseite.Execute();
}

void Gegenstandsauswahl()
{
    // Logik für Start
    

    
   

    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Sie ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" sind ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" auf ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" einer ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" einasamen ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" Insel ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" gestrandet ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("und");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" dürfen");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" 3");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" Sachen ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" mitnehmen. ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" Welche ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" wären ");
    Thread.Sleep(100);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" das?");
    Thread.Sleep(100);
   



















    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1:");
    Console.ForegroundColor = ConsoleColor.Green;
    Sache1 = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("2:");
    Console.ForegroundColor = ConsoleColor.Green;
    Sache2 = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("3:");
    Console.ForegroundColor = ConsoleColor.Green;
    Sache3 = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Die von dir ausgewählten Sachen sind:"  );
    Console.WriteLine(Sache1);
    Console.WriteLine(Sache2);
    Console.WriteLine(Sache3);
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (Sache1 == Messer || Sache2 == Messer || Sache3 == Messer)
    {
        Console.WriteLine("Gute Wahl, hätte ich genau so gemacht");
        Ort = "E1";
    }
    else
    {
        Ort = "Messernachfrage";
    }


}

void E7()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Zu guter Letzt,nachdem du zuhause bist, kannst du dich entscheiden, ob du zuerst heiß Baden gehst oder dir zuerst etwas zu Essen machst");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("   /> //  __");
    Console.WriteLine("    ___/ \\// _/ /");
    Console.WriteLine("  ,' , \\_/ \\/ _/__");
    Console.WriteLine(" /    _/ |--\\  `  `~,");
    Console.WriteLine("' , ,/  /`\\ / `  `   `,");
    Console.WriteLine("|    |  |  \\> `  `  ` |");
    Console.WriteLine("|  ,  \\/ ' '    `  `  /");
    Console.WriteLine("`,   '  '    ' `  '  /");
    Console.WriteLine("  \\ `      '  ' ,  ,'");
    Console.WriteLine("   \\ ` ` '    ,  ,/");
    Console.WriteLine("    `,  `  '  , ,'");
    Console.WriteLine("      \\ `  ,   /        ");
    Console.WriteLine("       `~----~'");
    Console.WriteLine("");
    Console.WriteLine("ODER");
    Console.WriteLine("");
    Console.WriteLine("          .     (_)         o                ");
    Console.WriteLine("   o      ____            _       o");
    Console.WriteLine("  _   ,-/   /)))  .   o  (_)   .");
    Console.WriteLine(" (_)  \\_\\  ( e(     O             _");
    Console.WriteLine(" o       \\/' _/   ,_ ,  o   o    (_)");
    Console.WriteLine("  . O    _/ (_   / _/      .  ,        o");
    Console.WriteLine("     o8o/    \\\\_/ / ,-.  ,oO8/( -TT");
    Console.WriteLine("    o8o8O | } }  / /   \\Oo8OOo8Oo||     O");
    Console.WriteLine("   Oo(\\\"\\\"o8\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"\\\"8oo\\\"\\\"\\\"\\\"\\\"\\\"\\\")");
    Console.WriteLine("  _   `\\`'                  `'   /'   o");
    Console.WriteLine(" (_)    \\                       /    _   .");
    Console.WriteLine("      O  \\           _         /    (_)");
    Console.WriteLine("o   .     `-. .----<(o)_--. .-'");
    Console.WriteLine("   --------(_/------(_<_/--\\_)--------");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E8 = Console.ReadLine();
    if (E8 == "Baden" || E8 == "baden")
    {
        Console.WriteLine("Weise Entscheidung");
        Console.WriteLine("Geschaft");
        Gewonnen = true;
     
    }
    else if (E8 != "Baden" || E8 != "baden")
    {
        Console.WriteLine("Weise Entscheidung");
        Console.WriteLine("Geschaft");
        Gewonnen = true;
        
    }
}





