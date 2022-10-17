using static System.Console;
Clear();

Write("Введите число N: ");
int numberforstartsum = Convert.ToInt32(ReadLine());
Write("Введите число M: ");
int numberforfinishsum = Convert.ToInt32(ReadLine());
int sum = SumNumbers(numberforstartsum,numberforfinishsum);
WriteLine(sum);

int SumNumbers(int num1,int num2)
{
    if (num1>num2)
    {    
    if (num1==num2) return num2;
    return num1 + SumNumbers(num1-1,num2);
    } 
    else 
    {
       if (num1==num2) return num1;
       return num2 + SumNumbers(num1,num2-1);
    } 
}
