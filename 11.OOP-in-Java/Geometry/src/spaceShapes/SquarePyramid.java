package spaceShapes;

import javax.management.BadAttributeValueExpException;

public class SquarePyramid extends SpaceShape {
	private double width;
	private double height;
	
	public SquarePyramid(Vertice3D vertex, double width, double height) {
		super(vertex);
		this.width = width;
		this.height = height;
	}

	public double getWidth() {
		return width;
	}
	
	public void setWidth(double width) throws BadAttributeValueExpException {
		if(width <= 0) {
			throw new BadAttributeValueExpException("Square Pyramid width cannot be a negative or zero!");
		}
		this.width = width;
	}
	
	public double getHeight() {
		return height;
	}
	
	public void setHeight(double height) throws BadAttributeValueExpException {
		if(height <= 0) {
			throw new BadAttributeValueExpException("Square Pyramid height cannot be a negative or zero!");
		}
		this.height = height;
	}

	@Override
	public double getVolume() {
		double squarePyramidVolume = (this.getWidth() * this.getWidth() * this.getHeight()) / 3;
		return squarePyramidVolume;
	}

	@Override
	public double getArea() {
		double sqrtSide = Math.sqrt(((this.getWidth() * this.getWidth()) / 4) + this.getHeight() * this.getHeight());
		double squarePyramidArea = this.getWidth() * this.getWidth() + 2 * this.getWidth() * sqrtSide;
		return squarePyramidArea;
	}

	@Override
	public String toString() {
		return String.format("(Square Pyramid: %s, Width = %.2f, Height = %.2f,"
				+ " Volume = %.2f, Area = %.2f",
				this.vertices.get(0), this.getWidth(), this.getHeight(),
				this.getVolume(), this.getArea());
	}
	
	
}
