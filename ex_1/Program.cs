Console.Clear();
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 0 || a == null)
{
    Console.WriteLine("you write not right number or don't input number");
}

else
{
    a*=a;
    Console.WriteLine($"your square: {a}"); //интерполяция строк 
    
}