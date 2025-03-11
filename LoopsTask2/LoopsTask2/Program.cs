//2. Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm misal:input 6, output quvveti deyil.  input 8 output quvvetidir

int number = Convert.ToInt32(Console.ReadLine());
bool is_pow = false;

for (int i = 2; i <= number; i *= 2)
{
    if (i == number) is_pow = true;
}

if (is_pow)
{
    Console.WriteLine("2-nin quvvetidir");
}
else
{
    Console.WriteLine("2-nin quvveti deyil");
}