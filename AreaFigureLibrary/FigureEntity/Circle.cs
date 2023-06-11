namespace AreaFigureLibrary.FigureEntity;

public class Circle : Figure
{
	public double Radius { get; set; }

	public Circle(double radius)
	{
		if(radius <= 0)
		{
			throw new ArgumentException("Radius must be greater than zero");
		}
		else
		{
			Radius = radius;
		}
	}

	public override double Area()
	{
		double area = Math.PI * Math.Pow(Radius, 2);
		return area;
	}
}
