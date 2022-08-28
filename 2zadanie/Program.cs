string Distanse()
{
    Console.WriteLine("Введите первую координату дляточки A: ");
    int A1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую координату для точки A: ");
    int A2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третью координату для точки A: ");
    int A3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите первую координату для точки B: ");
    int B1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую координату для точки B: ");
    int B2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третью координату для точки B: ");
    int B3 = Convert.ToInt32(Console.ReadLine());

    double dis = Math.Round(Math.Sqrt(Math.Pow(A1-B1, 2)+Math.Pow(A2-B2, 2)+Math.Pow(A3-B3, 2)), 2);
    return ($"Растояние между точками {dis}");
}

Console.WriteLine(Distanse());