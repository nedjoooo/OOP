package planeShapes;

public class Triangle extends PlaneShape {
	private double sideA = Vertice2D.getDistance(this.vertices.get(0), this.vertices.get(1));
	private double sideB = Vertice2D.getDistance(this.vertices.get(1), this.vertices.get(2));
	private double sideC = Vertice2D.getDistance(this.vertices.get(2), this.vertices.get(0));

	public Triangle(Vertice2D vertice1, Vertice2D vertice2, Vertice2D vertice3) {
		super(vertice1, vertice2, vertice3);
	}

	@Override
	public String toString() {
		return String.format("(Triangle: %s %s %s, Perimeter = %.2f, Area = %.2f)",
				this.vertices.get(0), this.vertices.get(1), this.vertices.get(2), 
				this.getPerimeter(), this.getArea());
	}

	@Override
	public double getPerimeter() {		
		double trianglePerimeter = this.sideA + this.sideB + this.sideC;
		return trianglePerimeter;
	}

	@Override
	public double getArea() {
		double halfPerimeter = getPerimeter() / 2;
		double sideByA = halfPerimeter - this.sideA;
		double sideByB = halfPerimeter - this.sideB;
		double sideByC = halfPerimeter - this.sideC;
		double triangleArea = Math.sqrt(halfPerimeter *
				(halfPerimeter - sideByA) * (halfPerimeter - sideByA) * (halfPerimeter - sideByA));
		return triangleArea;
	}
	
}
