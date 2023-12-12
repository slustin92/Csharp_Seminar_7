// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два                m = 2, n = 3 -> A(m,n) = 29
// неотрицательных числа m и n. 

//             n+1 :                m = 0:
// A(m,n) =    A(m-1, 1)            m >0, n=0:
//             A(m-1,A(m,n-1))      m>0,n>0



int FunAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunAckerman(m - 1, 1);
    }
     else if (m > 0 && n > 0)
    {
        return FunAckerman(m - 1, FunAckerman(m, n - 1));
    }
    else
    return 0;
}


int m = 3;
int n = 2;


Console.WriteLine(FunAckerman(m, n));
