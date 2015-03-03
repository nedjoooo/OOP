package spaceShapes;

public class Vertice3D {
	private double x;
	private double y;
	private double z;
	
	public Vertice3D(double x, double y, double z) {
		setX(x);
		setY(y);
		setZ(z);
	}

	public double getX() {
		return x;
	}
	
	public void setX(double x) {
		this.x = x;
	}
	
	public double getY() {
		return y;
	}
	
	public void setY(double y) {
		this.y = y;
	}
	
	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}

	@Override
	public String toString() {
		return String.format("{%.2f, %.2f %.2f}", this.getX(), this.getY(), this.getZ());
	}
	
	public static double getDistance(Vertice3D vertice1, Vertice3D vertice2) {
		double distanceByX = (vertice1.x - vertice2.x) * (vertice1.x - vertice2.x);
		double distanceByY = (vertice1.y - vertice2.y) * (vertice1.y - vertice2.y);
		double distance = Math.sqrt(distanceByX + distanceByY);
		return distance;
	}
}
