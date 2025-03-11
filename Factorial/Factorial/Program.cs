//0,1,1,2,3,5,8,13,21 fibonacci ededleri

int first = 0, last = 1, fib = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(fib);
    first = last;
    last = fib;
    fib = first + last;
    
}
