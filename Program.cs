//вариант:3.25
Console.Write( "Введите n:" ); 
int n =int.Parse( Console.ReadLine() );
int m = (((n - (n / 100) * 100)) / 10)+((n / 100) * 100)+((n - (((n/100)*100)+((n % 100) / 10)*10))*10);

Console.WriteLine(m);