package spaceShapes;

import javax.management.BadAttributeValueExpException;

public class Cuboid extends SpaceShape {
	private double width;
	private double height;
	private double depth;
	
	public Cuboid(Vertice3D vertex, double width, double height, double depth) throws BadAttributeValueExpException {
		super(vertex);
		setWidth(width);
		setHeight(height);
		setDepth(depth);		
	}

	public double getWidth() {
		return width;
	}
	
	public void setWidth(double width) throws BadAttributeValueExpException {
		if(width <= 0) {
			throw new BadAttributeValueExpException("Cuboid width cannot be a negative or zero!");
		}
		this.width = width;
	}
	
	public double getHeight() {
		return height;
	}
	
	public void setHeight(double height) throws BadAttributeValueExpException {
		if(height <= 0) {
			throw new BadAttributeValueExpException("Cuboid height cannot be a negative or zero!");
		}
		this.height = height;
	}
	
	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) throws BadAttributeValueExpException {
		if(depth <= 0) {
			throw new BadAttributeValueExpException("Cuboid depth cannot be a negative or zero!");
		}
		this.depth = depth;
	}	

	@Override
	public double getVolume() {
		double cuboidVolume = this.getWidth() * this.getHeight() * this.getDepth();
		return cuboidVolume;
	}

	@Override
	public double getArea() {
		double sideA = this.getWidth() * this.getHeight();
		double sideB = this.getHeight() * this.getDepth();
		double sideC = this.getDepth() * this.getWidth();
		double cuboidArea = (sideA + sideB + sideC) * 2;
		return cuboidArea;
	}

	@Override
	public String toString() {
		return String.format("(Cuboid: %s, Width = %.2f, Height = %.2f, Depth = %.2f,"
				+ " Volume = %.2f, Area = %.2f",
				this.vertices.get(0), this.getWidth(), this.getHeight(), this.getDepth(),
				this.getVolume(), this.getArea());
	}
	
	
}
