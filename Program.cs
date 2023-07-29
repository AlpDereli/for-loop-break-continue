// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sayi: ");
int sayac = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <=sayac; i++)
{
    if (i%2 ==1)
    {
        Console.WriteLine(i);
    }
}
int tektoplam = 0, cifttoplam = 0;
for (int s = 0; s < 1000; s++)
{
    if (s%2==1)
    {
          tektoplam +=s;
    }
    else
    {
        cifttoplam+=s;
    }
}

Console.WriteLine("Tekler toplami: " + tektoplam);
Console.WriteLine("Cift toplami: " + cifttoplam);

for (int i = 1; i <10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}
for (int i = 1; i <10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}