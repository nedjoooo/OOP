package planeShapes;

import javax.management.BadAttributeValueExpException;

public class Rectangle extends PlaneShape {
	private double width;
	private double height;
	
	public Rectangle(Vertice2D vertex, double width, double height) throws BadAttributeValueExpException {
		super(vertex);
		setWidth(width);
		setHeight(height);
	}

	public double getWidth() {
		return width;
	}
	
	public void setWidth(double width) throws BadAttributeValueExpException {
		if(width <= 0) {
			throw new BadAttributeValueExpException("Rectangle width cannot be a negative or zero!");
		}
		this.width = width;
	}
	
	public double getHeight() {
		return height;
	}
	
	public void setHeight(double height) throws BadAttributeValueExpException {
		if(height <= 0) {
			throw new BadAttributeValueExpException("Rectangle height cannot be a negative or zero!");
		}
		this.height = height;
	}

	@Override
	public double getPerimeter() {
		double rectanglePerimeter = this.getWidth() * 2 + this.getHeight() * 2;
		return rectanglePerimeter;
	}

	@Override
	public double getArea() {
		double rectangleArea = this.getWidth() * this.getHeight();
		return rectangleArea;
	}

	@Override
	public String toString() {
		return String.format("(Rectangle: %s, Width = %.2f, Height = %.2f, Perimeter = %.2f, Area = %.2f)", 
				this.vertices.get(0), this.getWidth(), this.getHeight(),
				this.getPerimeter(), this.getArea());
	}
	
}
