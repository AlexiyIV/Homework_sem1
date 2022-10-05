Console.Write("Введите N=");
int N = int.Parse(Console.ReadLine());
int count = 1;
while ( count < N + 1 ){
    if ( count % 2 == 0 ){
        Console.Write( count + ", ");
    }
    count++;
}
