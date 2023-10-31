// See https://aka.ms/new-console-template for more information

string test1 ="   /\\"+
                  "\n  /  \\"+
                  "\n /    \\"+
                  "\n/______\\";
Console.WriteLine(test1);

const string test2 = "     *****" +
                     "\n   **     **" +
                     "\n **         **" +
                     "\n**   Hello   **" +
                     "\n**   from    **" +
                     "\n **         **" +
                     "\n   **     **" +
                     "\n     *****";
Console.WriteLine(test2);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("   /\\");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("  /  \\");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(" /    \\");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("/______\\");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("   / \\     / \\");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("  /   \\   /   \\");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("  \\    \\ /    /");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("   \\         /");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("    \\       /");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("     \\     /");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("      \\   /");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("       \\ /");

Console.ForegroundColor = ConsoleColor.White;
const string vcard1 = "========== Visit Card =============";
const string name = "Name Surname";
const int age = 28;
const string responsibilities = "Software developer";
const string email = "johndoe@example.com";
const string phone = "+1 123-456-7890 ";
const string vcard2 = "===================================";

Console.WriteLine(vcard1+ "\n"+"Name: "+ name+ 
                  "\n"+"Age: " + age + 
                  "\n"+"Responsibilities: " + responsibilities + 
                  "\n"+"Email: " + email + 
                  "\n"+"Phone: " + phone + 
                  "\n"+ vcard2);