package spaceShapes;

import interfaces.AreaMeasurable;
import interfaces.Shape;
import interfaces.VolumeMeasurable;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class SpaceShape implements AreaMeasurable, VolumeMeasurable, Shape {
	List<Vertice3D> vertices;

	public SpaceShape(Vertice3D ... vertices) {
		this.vertices = new ArrayList<Vertice3D>(Arrays.asList(vertices));
	}

	@Override
	public double getVolume() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public double getArea() {
		// TODO Auto-generated method stub
		return 0;
	}
}
