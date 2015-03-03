package spaceShapes;

import javax.management.BadAttributeValueExpException;

public class Sphere extends SpaceShape {
	private double radius;
	
	public Sphere(Vertice3D vertex, double radius) throws BadAttributeValueExpException {
		super(vertex);
		setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) throws BadAttributeValueExpException {
		if(radius <= 0) {
			throw new BadAttributeValueExpException("Square Pyramid width cannot be a negative or zero!");
		}
		this.radius = radius;
	}

	@Override
	public double getVolume() {
		double radiusPowBy3 = this.getRadius() * this.getRadius() * this.getRadius();
		double sphereVolume = (4 * Math.PI * radiusPowBy3) / 3;
		return sphereVolume;
	}

	@Override
	public double getArea() {
		double radiusPowBy2 = this.getRadius() * this.getRadius();
		double sphereArea = 4 * Math.PI * radiusPowBy2;
		return sphereArea;
	}

	@Override
	public String toString() {
		return String.format("(Sphere: %s, Radius = %.2f,"
				+ " Volume = %.2f, Area = %.2f",
				this.vertices.get(0), this.getRadius(),
				this.getVolume(), this.getArea());
	}
	
	
}
