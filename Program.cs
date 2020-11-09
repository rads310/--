using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int n;
			int mk14 = 0;
			int mk7 = 0;
			int mk2 = 0;
			int max = 0;
			int res;
			int mpr = 0;
			int x;
			n = int.Parse(Console.ReadLine());
			for (i = 0; i < n; i++)
			{
				x = int.Parse(Console.ReadLine());
				if ((x % 7 == 0) && (x % 2 != 0) && (x > mk7))
				{
					mk7 = x;
				}
				if ((x % 2 == 0) && (x % 7 != 0) && (x > mk2))
				{
					mk2 = x;
				}
				if ((x % 14 == 0) && (x > mk14))
				{
					if (mk14 > max)
					{
						max = mk14;
					}
					mk14 = x;
				}
				else if (x > max)
				{
					max = x;
				}
			}
			res = int.Parse(Console.ReadLine());
			if (mk14 * max > mk7 * mk2)
			{
				Console.Write("Вычисленное контрольное значение: ");
				Console.Write(mk14 * max);
				Console.Write("\n");
				mpr = mk14 * max;
			}
			else
			{
				Console.Write("Вычисленное контрольное значение: ");
				Console.Write(mk7 * mk2);
				Console.Write("\n");
				mpr = mk7 * mk2;
			}
			if (res == mpr)
			{
				Console.Write("Контроль пройден");
			}
			else
			{
				Console.Write("Контроль не пройден");
			}

			return;
		}
    }
}
