using System;

namespace ConsoleApp6
{
   public class Program
    {
        static void Main()
        {
        }

        

       public static int Sign(int x)
        {
            if (x < 0) return (-1);
            else if (x == 0) return (0);
            else return (1);
        }
        static void Proc16()
        {
            int X = 3;
            Sign(X);
        }
        public static int RootsCount(int A, int B, int C)
        {
            int D = B * B - 4 * A * C;
            if (D > 0) return (2);
            else if (D == 0) return (1);
            else return (0);
        }
        static void Proc17()
        {
            int A = 9, B = 8, C = 10;
            RootsCount(A, B, C);
        }
        public static double CircleS(int R)
        {
            double S = 3.14 * R * R;
            return (S);
        }
        static void Proc18()
        {
            int R1 = 3, R2 = 8, R3 = 21;
            CircleS(R1);
            CircleS(R2);
            CircleS(R3);
        }
         public static double RingS(int R1, int R2)
        {
            double S1 = R1 *3.14;
            double S2 = R2 * 3.14;
            return (S1 - S2);
        }
        static void Proc19()
        {
            int R1 = 3, R2 = 1;
            RingS(R1, R2);
        }
        public static double TriangleP(int a, int h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            return (b);
        }
        static void Proc20()
        {
            int a = 6, h = 4;
            TriangleP(a, h);
        }
        static int SumRange(int A, int B)
        {
            int sum = 0;
            if (A > B) return (0);
            else
            {
                for (int i = A; i <= B; i++)
                {
                    sum = sum + i;
                }
                return (sum);
            }
        }
        static void Proc21()
        {
            int A = 2, B = 2, C = 0;
            if (C == 0) Console.Write(SumRange(A, B));
            else Console.WriteLine(SumRange(A, B) + SumRange(B, C));
        }
        static int Calc(int A, int B, int Op)
        {
            int rez = 0;
            switch (Op)
            {
                case 1:
                    rez = A - B;
                    break;
                case 2:
                    rez = A * B;
                    break;
                case 3:
                    rez = A / B;
                    break;
                default:
                    rez = A + B;
                    break;
            }
            return (rez);
        }
        static void Proc22()
        {
            int A = 3, B = 9, N1 = 2, N2 = 3, N3 = 1;
            Calc(A, B, N1);
            Console.WriteLine();
            Calc(A, B, N2);
            Console.WriteLine();
            Calc(A, B, N3);
        }
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0) return (1);
            else if (x < 0 && y > 0) return (2);
            else if (x < 0 && y < 0) return (3);
            else return (4);
        }
        static void Proc23()
        {
            int x1 = 2, y1 = 3, x2 = 3, y2 = 4, x3 = 1, y3 = 7;
            Quarter(x1, y1);
            Console.WriteLine();
            Quarter(x2, y2);
            Console.WriteLine();
            Quarter(x3, y3);
        }
        static bool Even(int K)
        {
            bool rez = true;
            if (K % 2 == 0) rez=true;
            else rez=false;
            return (rez);
        }
        static bool IsSquare(int K)
        {
            bool rez = true;
            if (K % K == 0) rez = true;
            else rez = false;
            return (rez);
        }

        static bool IsPrime(int N)
        {
            bool rez = true;
            int count = 0;
            for (int i = 2; i <= N / 2; i++)
                if (N % 2 == 0) count++;
            if (count >= 1) rez = false;
            else rez = true;
            return (rez);
        }
        static int DigitCount(int K)
        {
            int count = 0;
            while(K != 1)
            {
                count++;
                K = K / 10;
            }
            return (count);
        }
        static void Proc29()
        {
            int n1 = 3, n2 = 4, n3 = 6, n4 = 90;
            int sum = DigitCount(n1) + DigitCount(n2) + DigitCount(n3) + DigitCount(n4);
            Console.WriteLine(sum);
        }
        static int DigitN(int K, int N)
        {
            int rez = 0;
            for (int i = 1; i < K - N; i++)
            {
                rez = K % 10;
                K = K / 10;
            }
            return (rez);
        }
        static void Proc30()
        {
            int K1 = 2, K2 = 98, K3 = 0, K4 = 14, K5 = 21, N = 4;
            DigitN(K1, N);
            Console.WriteLine();
            DigitN(K2, N);
            Console.WriteLine();
            DigitN(K3, N);
            Console.WriteLine();
            DigitN(K4, N);
            Console.WriteLine();
            DigitN(K5, N);
        }
    }
}
