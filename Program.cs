// Work with variable data in C# console applications 

/*Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
//------------------------------------
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/
//code that adds and int and string and save result in an int
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

decimal myDecimal1 = 1.23456789m;
float myFloat = (float)myDecimal1;

Console.WriteLine($"Decimal: {myDecimal1}");
Console.WriteLine($"Float  : {myFloat}");

string first = "5";
int second = 7;
int sum = int.Parse(first) + second;
Console.WriteLine(sum);

string value1 = "5";
int value2 = 7;
int sumValues = Convert.ToInt32(value1) * value2;
Console.WriteLine(sumValues);

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
double total = 0;

for (int i = 0; i < values.Length; i++)
        {
            if (double.TryParse(values[i], out double number))
            {
                total += number;
            }
            else
            {
                message += values[i];
            }
        }

        Console.WriteLine("Message: " + message);
        Console.WriteLine("Total: " + total);