// See https://aka.ms/new-console-template for more information

string d = " Good afternoon ";
string c = "Vilnius";

// ************* First slide answers
//String class
Console.WriteLine(d.Length);
string f = ""; // Empty string definition
Console.WriteLine(c[2]); //l
Console.WriteLine(c.Substring(2,4));//lniu
Console.WriteLine(c.LastIndexOf("i"));//4





string s = "uncle";

// ************* Second slide answers
Console.WriteLine(d.Trim()); // cuts empty spaces in beginning and end
Console.WriteLine(s.Replace("d","m")); // same
Console.WriteLine(s.ToUpperInvariant()); // all upper case letters
Console.WriteLine(".ToString(i)");


// ************* Third slide answers
string test = "Hello my friend!";

Console.WriteLine(test.Substring(5)); // " my friend!"
Console.WriteLine(test.Substring(0,5)); // "Hello"
Console.WriteLine(test.Substring(8,7)); // " friend!"

char m = test[6];
Console.WriteLine(m); // letter "m"
string replacedE = test.Replace('e', 'W');
Console.WriteLine(replacedE); //
int myIndex = test.IndexOf("my");
Console.WriteLine(myIndex);


const string text = "some text";
Console.WriteLine("Select Task: ");
string selectTask = Console.ReadLine();
int selectedTask = int.Parse(selectTask);
if (selectedTask == 1)
{
    Console.WriteLine("Enter number:");
    string selection = Console.ReadLine();
    try
    {
        if (selection != null) Console.WriteLine("Letter is: " + text[int.Parse(selection)]);
        Console.WriteLine("Text lenght: "+text.Length);
    }
    catch (Exception e)
    {
        Console.WriteLine("Selected number is below or above of text length");
        throw;
    } 
}
else if (selectedTask == 2)
{
    string h = "My name is ";
    string full = s + Console.ReadLine();
    Console.WriteLine(h);
    Console.WriteLine("Substring: " + full.Substring(11));
    Console.WriteLine(full.Substring(0,3));
}
else if (selectedTask == 3)
{
    const string texts = "Hi my name is Darius";
    Console.WriteLine(texts.Substring(2));
    Console.WriteLine(texts.Replace('i','a'));
    Console.WriteLine(texts.IndexOf("a"));
    Console.WriteLine(texts.Trim('n'));
    Console.WriteLine(texts.ToLowerInvariant());
    Console.WriteLine(texts.ToUpperInvariant());
}

string PrintMyText(string s)
{
    Console.WriteLine(s);
    return s;
}
Console.WriteLine(PrintMyText("Some Text")); // Step 1 : Calling Method

