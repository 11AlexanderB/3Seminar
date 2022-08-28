Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
string res = "";
while(i<=N)
{
    res = res + Math.Pow(i, 3) + ",";
    i++;  
}
Console.WriteLine($"Куб чисел от 1 до {N}: {res}");
