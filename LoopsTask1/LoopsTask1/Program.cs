// 1. Verilmish ededin sade ve ya murekkeb oldugunu tapan alqoritm

int number = Convert.ToInt32(Console.ReadLine());
bool is_prime = true;

for  (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        is_prime = false;
        break;
    }
    
}

if (is_prime)
{
    Console.WriteLine("Sade");
}
else
{
    Console.WriteLine("Murekkeb");
}