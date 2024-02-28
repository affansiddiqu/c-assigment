// See https://aka.ms/new-console-template for more information

//1) Write a C# program that takes two numbers as input from the user and performs the following arithmetic operations:
//Addition , Subtraction , Multiplication , Division , Modulus (Remainder)

Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("\n Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double Addition = num1 + num2;
double Subtraction = num1 - num2;
double Multiplication = num1 * num2;

    Console.WriteLine($"\n addition: {Addition}");
    Console.WriteLine($"\n subtraction: {Subtraction}");
    Console.WriteLine($"\n multiplication: {Multiplication}");

if (num2 != 0)
{
    double Division = num1 / num2;
    double remainder = num1 % num2;
    Console.WriteLine($"\n division: {Division}");
    Console.WriteLine($"\n remainder: {remainder}");
}
else
{
    Console.WriteLine("invaild number");
}


//2) Write a C# program to compare two numbers entered by the user and print whether the first number is greater than, less than, or equal to the second number

        Console.Write("\n Enter the first number: ");
        double numb1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double numb2 = Convert.ToDouble(Console.ReadLine());

        if (numb1 > numb2)
        {
            Console.WriteLine($"{numb1} is greater than {numb2}");
        }
        else if (numb1 < numb2)
        {
            Console.WriteLine($"{numb1} is less than {numb2}");
        }
        else
        {
            Console.WriteLine($"{numb1} is equal to {numb2}");
        }
//3) Write a C# program to print the multiplication table of a number entered by the user using a loop (for, while, or do-while).

//For Loop

Console.Write("\n For Loop: ");
Console.Write("\n Enter a number for table: ");
int table = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Multiplication Table for {table}:");
for (int t = 1; t <= 10; t++)
{
    int result = table * t;
    Console.WriteLine($"{table} * {t} = {result}");
}

//While Loop

Console.Write("\n While Loop: ");
Console.Write("\n Enter a number for table: ");
int table1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nMultiplication Table for {table1}:");
int t1 = 1;
while (t1 <= 10)
{
    int result1 = table1 * t1;
    Console.WriteLine($"{table1} * {t1} = {result1}");
    t1++;
}

//Do While loop

Console.Write("\n Do While Loop: ");
Console.Write("\n Enter a number for table: ");
int table2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Multiplication Table for {table2}:");
int t3 = 1;
do
{
    int result2 = table2 * t3;
    Console.WriteLine($"{table2} * {t3} = {result2}");
    t3++;
} while (t3 <= 10);

//4) Write a C# program to print a pattern of asterisks (*) in the following format using nested loops:
Console.Write("\n Nested Loops:\n");
int line = 5;

for (int a = 1; a <= line; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop control statements (break and continue).
Console.Write("\n Sum of Even Number (1 to 100) \n");

int even = 0;

for (int c = 1; c < 100; c++)
{
    if (c % 2 != 0)
    {
        continue;
    }
    even += c;
    if (c > 50)
    {
        break;
    }
    Console.WriteLine(c);
}
Console.WriteLine("\n Sum Of All Even Number (1 to 100) " + even);

//6) Write a C# program to reverse a string entered by the user without using any built-in reverse functions or methods.

Console.Write("\n Enter a String");
string affan = Console.ReadLine();

Console.WriteLine($"\n Reverse String for {affan}:\n");

int length = affan.Length;

int i = length -1;
while (i >= 0)
{
    Console.Write(affan[i]);
    i--;
}

//7) Write a C# program to print all the prime numbers between 1 and 100 using a loop and conditional statements.

Console.WriteLine("\n Prime numbers between (1 and 100)");

for (int number = 2; number <= 100; number++)
{
    bool Prime = true;

    for (int inc = 2; inc < number; inc++)
    {
        if (number % inc == 0)
        {
            Prime = false; break;
        }
    }

    if (Prime)
    {
        Console.Write($"{number} ");
    }
}