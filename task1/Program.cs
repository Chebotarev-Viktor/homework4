
int numA = 0;
int numB = 0;
int sum = 0;

while(true)
{
    Console.WriteLine("Введите целое число А:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        numA = number; break;
    }
    else Console.WriteLine("некорректный ввод");
}

while(true)
{
    Console.WriteLine(" число В:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        if(number < 0) 
        {
            Console.WriteLine("некоректный ввод");
            continue;
        }
        else numB = number; break;
    }
    else Console.WriteLine("некоректный ввод");
}

Console.WriteLine("число " + numA + " в степени " + numB + " = " + Calculate(numA, numB));


int Calculate(int a, int b)
{
    if (a == 0 && b == 0)
    {
        sum = 1;
    }
    else
    {
        sum = a;
        for(int i = 1; i < b; i++)
        {
            sum = sum * a;
        }
    }
    return sum;
}