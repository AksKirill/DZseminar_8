// // Задача 64  -задается число N, требуется вывести числа в диапазоне от N до 1

// Console.WriteLine("Введите число N: ");
// int N=Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(NumbersRec(N));

// string NumbersRec(int N)
// {
//    if (N>0) return $"{N} " + NumbersRec(N-1);
//    else return String.Empty;
// }


// ////////////////////////////////////////////////////////////
// //Задача 66  -задаются числа M и N, требуется вывести сумму всех натукральных числел в диапазоне от M до N

// int M=ReadInt("Введите число M: ");
// int N=ReadInt("Введите число N: ");
// if (M<N)
// {
//     PrintNambers(N,M);
// }
// else 
// {
//     PrintNambers(M,N);
// }
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int PrintNambers(int M, int N)
// {
//     if (M>N)
//     {
//         return 0;
//     }
//    return M + PrintNambers(M+1,N);
   
// }
//   Console.WriteLine(PrintNambers(M,N));
////////////////////////////////////////////////////////////
// //Задача 68  -вычислить функцию аккермана при помощи рекурсаа. задаются неотрицательные числа M и N

// int m=ReadInt("Введите число m: ");
// int n=ReadInt("Введите число n: ");

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// static int Akk(int n, int m)
// {
//     if (n==0)
//     {
//         return m+1;
//     }
//     else
//     {
//         if ((n !=0)&&(m==0))
//             {
//                 return Akk(n-1,1);
//             }
//             else
//             {
//                 return Akk(n-1, Akk(n,m-1));
//             }
//     }
// }
// Console.WriteLine(Akk(m,n));
