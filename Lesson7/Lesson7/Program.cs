try
{
    Console.WriteLine("Введите количество минут:");
    int min = int.Parse(Console.ReadLine());
    
    int b = 1;
    int bacteriaCount = b * (int)Math.Pow(2, min);
    
    Console.WriteLine($"Через {min} минут количество бактерий будет: {bacteriaCount}");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}