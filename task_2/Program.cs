Console.Write("Введите a=");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b=");
int b = int.Parse(Console.ReadLine());
if ( a > b ){
    Console.WriteLine("a больше");
}
else if ( a < b ){
    Console.WriteLine("b больше");
}
else{
    Console.WriteLine( "a и b равны");
}
