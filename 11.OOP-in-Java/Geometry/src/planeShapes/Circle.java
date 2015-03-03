package planeShapes;

import javax.management.BadAttributeValueExpException;

public class Circle extends PlaneShape {
	private double radius;
	
	public Circle(Vertice2D vertex, double radius) throws BadAttributeValueExpException {
		super(vertex);
		setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) throws BadAttributeValueExpException {
		if(radius <= 0) {
			throw new BadAttributeValueExpException("Rectangle width cannot be a negative or zero!");
		}
		this.radius = radius;
	}

	@Override
	public double getPerimeter() {
		double circlePerimeter = 2 * this.getRadius() * Math.PI;
		return circlePerimeter;
	}

	@Override
	public double getArea() {
		double circleArea = this.getRadius() * this.getRadius() * Math.PI;
		return circleArea;
	}

	@Override
	public String toString() {
		return String.format("(Circle: %s, Radius = %.2f, Perimeter = %.2f, Area = %.2f)", 
				this.vertices.get(0), this.getRadius(), this.getPerimeter(), this.getArea());
	}
	
}
