using TextAdventure;

string Nahrungssuche = "Nahrungssuche";
string Jo = "Jo";
string Ja = "Ja";
string Messer = "Messer";
bool gameOver = false;
bool Gewonnen = false;

string Ort = "Gegenstandsauswahl";
string? Sache1, Sache2, Sache3;

ConsoleColor[] consoleColors = new ConsoleColor[]
{
    ConsoleColor.Red,
    ConsoleColor.Magenta,
    ConsoleColor.Yellow
};
int wordCount = 0;

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
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Du hast gewonnen!");

}





void Messerfrage()
{
    SlowWriteLine("Sicher, dass du kein Messer mitnehmen möchtest?");
    
    Console.ForegroundColor = ConsoleColor.White;
    string? Antwort = Console.ReadLine();
    if (Antwort == Ja || Antwort == Jo)
    {
        SlowWriteLine("Dann bin ich gespant, ob du überleben wirst");
        



        Ort = "E1";
    }
    else if (Antwort == "Nein")
    {
        Ort = "Gegenstandsauswahl";
    }
}

void E1()
{


    SlowWriteLine("Als nächstes musst du dich entscheiden, ob du dich zuerst um die Nahrungssuche oder um eine Unterkunft kümmerst");

    

    Console.ForegroundColor = ConsoleColor.Green;
    string? E1 = Console.ReadLine();

    if (E1 == Nahrungssuche)
    {

        SlowWriteLine("Du hättest dich zuerst mit der Unterkunft ausseinandersetzen sollen, da ein starkes Unwetter aufzieht. Aufgrund dessen das du kein Schutz hast wirst du von einem Blitz getroffen und bist Tod");
        




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
        SlowWriteLine("Du hast die richtige Entscheidung getroffen, da ein starkes Unwetter aufzieht");
        

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
    SlowWriteLine("Nachdem das Unweter vorbei gezogen ist, gehst du auf die Suche nach Nahrung und siehst eine dir unbekannte Frucht. Ist du sie?");
;    
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("  \\");
    Console.WriteLine(" ()()");
    Console.WriteLine("()()()");
    Console.WriteLine(" ()()");
    Console.WriteLine("  ()");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E3 = Console.ReadLine();
    if (E3 == Ja || E3 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Dann hast du Glück gehabt, die Frucht war nicht giftig");
        Ort = "E4";
    }
    else if (E3 == "Nein")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Dann musst du weiter suchen");
        Ort = "E3";
    }
}

void E3()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    SlowWriteLine("Möchtest du dich auf die Lauer legen und versuchen ein Tier zu erlegen?");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E5 = Console.ReadLine();
    if (E5 == Ja || E5 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Dann liegst du jz auf der Lauer");
        Ort = "E5";
    }
    else if (E5 == "Nein")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Dann verhungerst du");
        Ort = "Tod";
    }
}

void E4()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    SlowWriteLine("Super, du hast bis jetzt alles richtig gemacht. Nun baust du dir ein Floß aus Palmen. Einige Zeit später ist das Floß fertig gebaut, jedoch als du losfahren möchtest siehst du eine dunkle Wolke am Himmel. Möchtest du trotzdem fahren?");
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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E6 = Console.ReadLine();
    if (E6 == Ja || E6 == Jo)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Schade, das wars mit dir, da dein Floß bei dem unwetter mitten auf dem Meer von einem Blitz getroffen wurde");
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
        SlowWriteLine("Gute Entscheidung. Du fährst einen Tag später los.");
        Ort = "E6";
    }


}

void E5()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    SlowWriteLine("Vor dir läuft dieser Affe, möchtest du ihn töten?");
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





    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string ? E6 = Console.ReadLine();
if (E6 == Ja || E6 == Jo)
{
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Während du versuchst den Affen zu töten, kommen hunderte von Affen zur Unterstützung und töten dich");
    Ort = "Tod";
}
else if (E6 == "Nein")
{
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Währed du auf der Lauer liegst kommt dieser Skopion von hinten und sticht dich");
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
    SlowWriteLine("Als du auf dem offenem Meer bist, siest du in 100 Meter entfernung ein sinkendes schiff. Paddelst du gegen die Strömung an, um zu helfen oder lässt du dich weiter zum Festland treiben? wählst du Option 1 oder 2 ");
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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Green;
    string? E7 = Console.ReadLine();
    if (E7 == "1")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Du bist sehr hilfsbereit, jedoch ist die Strömung zu stark und du schaffst es nicht.");
        Ort = "E7";
    }
    else if (E7 == "2")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        SlowWriteLine("Du bist nicht sehr hilfsbereit aber es war die bessere Entscheidung, da du nicht gegen die Strömung angekommen wärst");
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



    SlowWriteLine("Du bist auf einer einsamen Insel gestrandet und darst 3 Sachen mitnehmen. Welche wären das?");


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
    Console.WriteLine("1:"+Sache1);
    Console.WriteLine("2:"+Sache2);
    Console.WriteLine("3:"+Sache3);
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (Sache1 == Messer || Sache2 == Messer || Sache3 == Messer)
    {
        SlowWriteLine("Gute Wahl, hätte ich genau so gemacht");
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
    SlowWriteLine("Zu guter Letzt,nachdem du zuhause bist, kannst du dich entscheiden, ob du zuerst heiß Baden gehst oder dir zuerst etwas zu Essen machst");
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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Antwort:");
    Console.ForegroundColor = ConsoleColor.Cyan;
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

void SlowWriteLine(string message)
{
    var words = message.Split(' ');
    foreach (var word in words)
    {
        wordCount++;
        Console.ForegroundColor = consoleColors[wordCount % 3];
        Console.Write(word);
        Console.Write(" ");
        Thread.Sleep(175);
    }
    Console.WriteLine("");
}



