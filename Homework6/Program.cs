
//SHOW CHARACTER

static void ShowCharacter(string? word, int letter)
{
    Console.WriteLine(word?[letter - 1]);
}

ShowCharacter("dog", 2);
ShowCharacter("barbeque", 7);
ShowCharacter("potato", 3);





//RETAIL PRICE


 Console.Write("Please enter your item's wholesale cost. ");
   decimal whole = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Please enter your item's markup percentage. ");
   decimal mark = Convert.ToDecimal(Console.ReadLine());

CalculateRetail(whole, mark);

static void CalculateRetail(decimal wholesale, decimal markup)
{
    decimal markupVariable = Convert.ToDecimal("0.01");
    decimal markupValue = markup * markupVariable;
    decimal retail = (wholesale * markupValue) + wholesale;


    Console.WriteLine($"The retail price is ${retail}!");

}





//TEMP TABLE

static decimal Celsius(decimal fahrenheit)
{
    decimal calcVar = Convert.ToDecimal(0.56);
    decimal celsius = calcVar * (fahrenheit - 32);
    return celsius;

}

decimal fahren = 80;

for (int i = 0; i < 21; i++)
{
    Console.WriteLine($"{fahren} degrees F = {Celsius(fahren++)} degrees C!");
}





//PRIME NUMBERS

/*
Console.WriteLine("Enter a number to see if it is prime or not! ");
int primeTest = Convert.ToInt32(Console.ReadLine());

static void IsPrime(int prime)
{
    if(prime == 1 )
}

//so confused

*/