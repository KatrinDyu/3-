Console.Clear();
Console.WriteLine("vvedite chislo");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < n)
{
i ++;
 Console.WriteLine($"poryadkovoe chislo v kube= {Math.Pow(i, 3)}");
}