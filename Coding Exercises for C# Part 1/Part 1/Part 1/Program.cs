//Exercise 1
/*Console.WriteLine("What is your name?");
string isim = Console.ReadLine();
Console.WriteLine("Hello " + isim);*/

//Exercise 2
/*string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

Console.WriteLine(number1 + number2);*/

//Exercise 3
/*Console.Write("Input 1: ");
int sayi1 = int.Parse(Console.ReadLine());

Console.Write("Input 2: ");
int sayi2 = int.Parse(Console.ReadLine());

Console.Write("Input 3: ");
string islemTipi = Console.ReadLine();

int sonuc = 0;
string sembol = "";

if (islemTipi == "add")
{
    sonuc = sayi1 + sayi2;
    sembol = "+";
}
else if (islemTipi == "subtract")
{
    sonuc = sayi1 - sayi2;
    sembol = "-";
}
else if (islemTipi == "multiply")
{
    sonuc = sayi1 * sayi2;
    sembol = "*";
}

Console.WriteLine($"Answer is {sonuc} ({sayi1}{sembol}{sayi2}={sonuc})");*/

//Exercise 4
/*Console.Write("Input 1: ");
int sayi1 = int.Parse(Console.ReadLine());

Console.Write("Input 2: ");
int sayi2 = int.Parse(Console.ReadLine());

Console.Write("Input 3: ");
string islemTipi = Console.ReadLine();

double sonuc = 0;
string sembol = "";
bool hata = false;

if (islemTipi == "add")
{
    sonuc = sayi1 + sayi2;
    sembol = "+";
}
else if (islemTipi == "subtract")
{
    sonuc = sayi1 - sayi2;
    sembol = "-";
}
else if (islemTipi == "multiply")
{
    sonuc = sayi1 * sayi2;
    sembol = "*";
}
else if (islemTipi == "divide")
{
    sonuc = (double)sayi1 / sayi2;
    sembol = "/";
}
else 
{
    hata = true;
    Console.WriteLine("Input 3 is wrong type.");
}
if (!hata)
{
    Console.WriteLine($"Answer is {sonuc} ({sayi1}{sembol}{sayi2}={sonuc})");
}*/

//Exercise 5
/*double vdpAvg = (1 + 2 + 1) / 3.0;
double vaAvg = (3 + 4 + 3) / 3.0;
double pAvg = (6 + 3 + 4) / 3.0;

Console.WriteLine("Name: Standings -> Average Standing");

Console.WriteLine($"Van Der Poel: 1-2-1 -> {vdpAvg:F2}");
Console.WriteLine($"Van Aert: 3-4-3 -> {vaAvg:F2}");
Console.WriteLine($"Pedersen: 6-3-4 -> {pAvg:F2}");

if (vdpAvg < vaAvg && vdpAvg < pAvg)
{
    Console.WriteLine($"Winner is Van Der Poel and his average standing is {vdpAvg:F2}");
}
else if (vaAvg < vdpAvg && vaAvg < pAvg)
{
    Console.WriteLine($"Winner is Van Der Poel and his average standing is {vaAvg:F2}");
}
else
{
    Console.WriteLine($"Winner is Van Der Poel and his average standing is {pAvg:F2}");
}*/

//Exercise 6
/*Console.WriteLine("What is the name of the Cyclist?");
string name = Console.ReadLine();

Console.WriteLine("How many race did he finish?");
int raceCount = int.Parse(Console.ReadLine());

Console.WriteLine("What are the results for " + name + "?");
int[] results = new int[raceCount];
for (int i = 0; i < raceCount; i++)
{
    results[i] = int.Parse(Console.ReadLine());
}

string resultStr = "";
for (int i = 0; i < raceCount; i++)
{
    if (i == 0)
        resultStr = resultStr + results[i];
    else
        resultStr = resultStr + "-" + results[i];
}

int toplam = 0;
for (int i = 0; i < raceCount; i++)
{
    toplam = toplam + results[i];
}
double ortalama = (double)toplam / raceCount;

Console.WriteLine("Results for " + name + ": " + resultStr);
Console.WriteLine("His average standing is " + Math.Round(ortalama, 2));*/

//Exercise 7
/*Random random = new Random();

int zar1 = random.Next(1, 7);
int zar2 = random.Next(1 ,7);
int zar3 = random.Next(1, 7);

int result = zar1 + zar2 + zar3;

Console.WriteLine($"Dice roll: {zar1} + {zar2} + {zar3} = {result}");

if (zar1 == zar2 && zar2 == zar3)
{
    result = result + 6;
    Console.WriteLine("You rolled triples! +6 bonus to total!");
}
else if (zar1 == zar2 || zar1 == zar3 || zar2 == zar3)
{
    result = result + 2;
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
}
if (result >= 15)
{
    Console.WriteLine("You win!");
}
else
    Console.WriteLine("Sorry, you lose");*/

//Exercise 8
/*Console.WriteLine("Please enter a quote from a game: ");
string quote = Console.ReadLine();

Console.WriteLine("Please enter a letter to count: ");
string letter = Console.ReadLine();

string reverse = "";
for (int i = quote.Length - 1; i >= 0; i--)
{
    reverse = reverse + quote[i];
}

int number = 0;
for (int i = 0; i < quote.Length; i++)
{
    if (quote[i] == letter[0])
    {
        number = number + 1;
    }
}

Console.WriteLine(reverse);
Console.WriteLine($"{letter} appears {number} times.");*/