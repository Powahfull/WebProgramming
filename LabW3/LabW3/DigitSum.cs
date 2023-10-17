using System;
namespace LabW3
{
	public class DigitSum
	{
		public static int DigitS(int a)
		{
			int total = 0;
			while (a >0)
			{
				total += a % 10;
				a = a / 10;
			}
            return total;
        }
	}
}


