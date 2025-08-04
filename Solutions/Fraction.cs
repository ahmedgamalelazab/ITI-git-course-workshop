internal class Program
{
	public int  static Number (int num)
     { 
		 return num;
	 }
	public class FractionNumber
	{
		int numerator;
		int denominator;


		public void SetNumberator(int _numerator) { numerator = _numerator; }
		public void SetDenomerator(int _denomirator) { denominator = _denomirator; }
		public int GetNumberator() { return numerator; }
		public int GetDenomerator() { return denominator; }
		public FractionNumber(int _numerator, int _denomirator)
		{
			numerator = _numerator;
			denominator = _denomirator;
		}
		public void Simplify()
		{
			int min = (numerator < denominator) ? numerator : denominator;
			int GCD = 1;
			for (int i = 1; i <= min; i++)
			{
				if (numerator % i == 0 && denominator % i == 0)
				{
					GCD = i;
				}

			}
			numerator = numerator / GCD;
			denominator = denominator / GCD;
		}
		public static FractionNumber operator +(FractionNumber f1, FractionNumber f2)
		{
			FractionNumber result;
			if (f1.denominator == f2.denominator)

			{ result = new FractionNumber(f1.numerator + f2.numerator, f1.denominator); }
			else
			{
				int commonDenominator = f1.denominator * f2.denominator;
				int newNumerator = (f1.numerator * f2.denominator) + (f2.numerator * f1.denominator);

				result = new FractionNumber(newNumerator, commonDenominator);
			}
			result.Simplify();
			return result;
		}
		public static FractionNumber operator -(FractionNumber f1, FractionNumber f2)
		{
			FractionNumber result;
			if (f1.denominator == f2.denominator)
			{
				result = new FractionNumber(f1.numerator - f2.numerator, f1.denominator);
			}
			else
			{
				int commonDenominator = f1.denominator * f2.denominator;
				int newNumerator = (f1.numerator * f2.denominator) - (f2.numerator * f1.denominator);
				result = new FractionNumber(newNumerator, commonDenominator);
			}
			result.Simplify();
			return result;
		}
		public static FractionNumber operator *(FractionNumber f1, FractionNumber f2)
		{
			FractionNumber result;
			result = new FractionNumber((f1.numerator * f2.numerator), (f1.denominator * f2.denominator));
			result.Simplify();
			return result;
		}
		public static FractionNumber operator /(FractionNumber f1, FractionNumber f2)
		{
			int newNumerator = f1.numerator * f2.denominator;
			int newDenominator = f1.denominator * f2.numerator;
			FractionNumber result = new FractionNumber(newNumerator, newDenominator);
			result.Simplify();
			return result;
		}
		public static bool operator >(FractionNumber f1, FractionNumber f2)
		{
			int commpnDenuminator = f1.denominator * f2.denominator;
			int f1Num = (commpnDenuminator / f1.denominator) * f1.numerator;
			int f2Num = (commpnDenuminator / f2.denominator) * f2.numerator;
			return f1Num > f2Num;


		}
		public static bool operator <(FractionNumber f1, FractionNumber f2)
		{
			int commonDenuminator = f1.denominator * f2.denominator;
			int f1Num = (commonDenuminator / f1.denominator) * f1.numerator;
			int f2Num = (commonDenuminator / f2.denominator) * f2.numerator;
			return f1Num < f2Num;
		}
		public static bool operator ==(FractionNumber f1, FractionNumber f2)
		{
			int commonDenuminator = f1.denominator * f2.denominator;
			int f1Num = (commonDenuminator / f1.denominator) * f1.numerator;
			int f2Num = (commonDenuminator / f2.denominator) * f2.numerator;
			return f1Num == f2Num;
		}
		public static bool operator !=(FractionNumber f1, FractionNumber f2)
		{
			int commonDenuminator = f1.denominator * f2.denominator;
			int f1Num = (commonDenuminator / f1.denominator) * f1.numerator;
			int f2Num = (commonDenuminator / f2.denominator) * f2.numerator;
			return f1Num != f2Num;
		}

		public void print()
		{
			if (numerator == 0 || numerator % denominator == 0)
			{
				int simplified = numerator / denominator;
				Console.WriteLine($"{numerator} / {denominator} = {simplified}");
			}
			else if (denominator == 0) { Console.WriteLine("Cannot Devide By Zero"); }
			else { Console.WriteLine($"{numerator} / {denominator}"); }
		}
	}

	private static void Main(string[] args)
	{
		//FractionNumber f1 = new FractionNumber(1, 5);
		//FractionNumber f2 = new FractionNumber(4, 7);
		//FractionNumber f3 = f1 + f2;
		//FractionNumber f3 = f1 - f2;
		//FractionNumber f3 = f1 * f2;
		//bool result = f1 > f2;
		//Console.WriteLine(result);
		//bool result = f1 != f2;
		//Console.WriteLine(result);
		//f3.print();
	}
}