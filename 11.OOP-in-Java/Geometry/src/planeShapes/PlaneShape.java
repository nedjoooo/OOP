package planeShapes;

import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;
import interfaces.Shape;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class PlaneShape implements PerimeterMeasurable, AreaMeasurable, Shape {
	protected List<Vertice2D> vertices;

	public PlaneShape(Vertice2D ... vertices) {
		this.vertices = new ArrayList<Vertice2D>(Arrays.asList(vertices));
	}

	@Override
	public double getPerimeter() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public double getArea() {
		// TODO Auto-generated method stub
		return 0;
	}
	
}
