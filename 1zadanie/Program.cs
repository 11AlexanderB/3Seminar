Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rev = 0;
int n = num;

while(n>0)
{
    int x = n%10;
    rev = rev*10+x;
    n = n/10;
}
if(rev == num) Console.WriteLine($"Число {num} является палиндромом");
else Console.WriteLine($"Число {num} не является палиндромом");
