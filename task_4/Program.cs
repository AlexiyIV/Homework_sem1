Console.Write("Введите a=");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b=");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите c=");
int c = int.Parse(Console.ReadLine());
int max = a;
if ( a < b ){
    max = b;
}
else if ( a < c ){
    max = c;
}
if ( c > b ){
    max = c;
}
Console.WriteLine( max );
