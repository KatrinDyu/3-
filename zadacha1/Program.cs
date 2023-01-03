        Console.Clear();
        Console.WriteLine("vvedite 5tiznachnoe chislo");
        int chislo = Convert.ToInt32(Console.ReadLine());
        int vtorcif = chislo / 1000;
        int chetvcif = chislo / 10;
       Console.WriteLine($"ishodnoe chislo {chislo}");
       if (chislo <= 9999 || chislo > 99999)
        {
            Console.WriteLine("eto chislo nam ne podhodit");
        }
                   else if ((chislo - chislo % 10000) / 10000 == chislo % 10 && (vtorcif % 10 == chetvcif % 10))
             {
              Console.WriteLine("polindrom");
              }
                else if ((chislo - chislo % 10000) / 10000 != chislo % 10 && (vtorcif % 10 != chetvcif % 10))
             {
              Console.WriteLine(" ne polindrom");
              }
  