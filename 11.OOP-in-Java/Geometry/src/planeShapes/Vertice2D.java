package planeShapes;

public class Vertice2D {
	private double x;
	private double y;
	
	public Vertice2D(double x, double y) {
		setX(x);
		setY(y);
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
	
	@Override
	public String toString() {
		return String.format("{%.2f, %.2f}", this.getX(), this.getY());
	}
	
	public static double getDistance(Vertice2D vertice1, Vertice2D vertice2) {
		double distanceByX = (vertice1.x - vertice2.x) * (vertice1.x - vertice2.x);
		double distanceByY = (vertice1.y - vertice2.y) * (vertice1.y - vertice2.y);
		double distance = Math.sqrt(distanceByX + distanceByY);
		return distance;
	}
}
