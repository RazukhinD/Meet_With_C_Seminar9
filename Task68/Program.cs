using static System.Console;
Clear();

Write("Введите число M: ");
int firstNumAccermanFunc = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int secondNumAccermanFunc = Convert.ToInt32(ReadLine());
int accremanFuncValue = AccermanFunc(firstNumAccermanFunc,secondNumAccermanFunc);
WriteLine(accremanFuncValue);


int AccermanFunc(int m,int n)
{
    if(m==0) return n+1;
    if (n==0) return AccermanFunc(m-1,1);
    return AccermanFunc(m-1,AccermanFunc(m,n-1));
}
