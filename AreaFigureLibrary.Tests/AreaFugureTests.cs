using AreaFigureLibrary.FigureEntity;
using NUnit.Framework;

namespace AreaFigureLibrary.Tests;

[TestFixture]
public class AreaFugureTests
{
	[Test]
	public void CreateTriangleSideLessZero()
	{
		try
		{
			new Triangle(-2, 5, 4);
		}
		catch (ArgumentException)
		{

		}
	}

	[Test]
	public void CreateCircleRadiusLessZero()
	{
		try
		{
			new Circle(-3);
		}
		catch (ArgumentException)
		{

		}
	}

	[Test]
	public void CheckRightTriangle()
	{
		var triangle = new Triangle(5, 4, 3);
		Assert.IsTrue(triangle.CheckRightTriangle());
	}

	[Test]
	public void CheckNotRightTriangle()
	{
		var triangle = new Triangle(5, 4.1, 3);
		Assert.IsFalse(triangle.CheckRightTriangle());
	}

	[Test]
	public void AreaTriangle()
	{
		var triangle = new Triangle(5, 4, 3);
		Assert.AreEqual(6, triangle.Area());
	}

	[Test]
	public void AreaCircle()
	{
		var circle = new Circle(Math.PI);
		Assert.AreEqual(Math.Pow(Math.PI, 3), circle.Area());
	}
}
