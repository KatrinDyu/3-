Console.Clear();
Console.WriteLine ("vvedite Xa");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("vvedite Ya");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("vvedite Za");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("vvedite Xb");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("vvedite Yb");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("vvedite Zb");
int zb = Convert.ToInt32(Console.ReadLine());
double rass = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
Console.WriteLine($"rasstoyanie mejdu a i b = {rass}");// a i b sideli na trube