namespace AreaFigureLibrary.FigureEntity;

public class Triangle : Figure
{
	public double A { get; set; }
	public double B { get; set; }
	public double C { get; set; }

	public Triangle(double a, double b, double c)
	{
		if (a <= 0 || b <= 0 || c <= 0)
		{
			throw new ArgumentException("The value of the side of the triangle must be greater than zero!");
		}
		
		if (a + b > c && a + c > b && b + c > a)
		{
			A = a;
			B = b;
			C = c;
		}
		else
		{
			throw new ArgumentException("According to the dimensions of the sides, it is impossible to form a triangle");
		}
	}

	public override double Area()
	{
		double semiPerimetr = (A + B + C) / 2;
		double area = Math.Sqrt(semiPerimetr * (semiPerimetr - A) * (semiPerimetr - B) * (semiPerimetr - C));
		return area;
	}

	public bool CheckRightTriangle()
	{
		double[] sidesTriangle = { A, B, C };
		Array.Sort(sidesTriangle);

		if (Math.Pow(sidesTriangle[2], 2) == (Math.Pow(sidesTriangle[1], 2) + Math.Pow(sidesTriangle[0], 2)))
		{
			return true;
		}

		return false;
	}
}
