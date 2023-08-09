// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int triHead = 10;
int triNum = 55;
var divisors = 2; // 1 and the number itself will always be factors

var t0 = new Stopwatch();
t0.Start();

while (divisors <= 500)
{
    divisors = 2;
    triHead++;
    triNum += triHead;
    int max = triNum / 2;

    for (int i = 2; i <= max; i++)
    {
        if (triNum % i == 0)
        {
            divisors += 2;
            max = triNum / i;
        }
        if (divisors == 501)
        {
            break;
        }
    }
}
t0.Stop();
Console.WriteLine($"Answer {triNum}, {t0.ElapsedMilliseconds} MS");