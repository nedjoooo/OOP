import interfaces.Shape;
import interfaces.VolumeMeasurable;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import javax.management.BadAttributeValueExpException;

import planeShapes.Circle;
import planeShapes.PlaneShape;
import planeShapes.Rectangle;
import planeShapes.Triangle;
import planeShapes.Vertice2D;
import spaceShapes.Cuboid;
import spaceShapes.SpaceShape;
import spaceShapes.SquarePyramid;
import spaceShapes.Vertice3D;
import spaceShapes.Sphere;


public class GeometryTest {

	public static void main(String[] args) throws BadAttributeValueExpException {
		Triangle triangle = new Triangle(
				new Vertice2D(3, 4),
				new Vertice2D(-5, 12),
				new Vertice2D(-20, -12));
		
		Rectangle rectangle = new Rectangle(new Vertice2D(4, 4), 3, 4);
		
		Circle circle = new Circle(new Vertice2D(-2, 2), 3);
		
		SquarePyramid squarePyramid = new SquarePyramid(new Vertice3D(2, 3, 4), 4, 5);
		
		Cuboid cuboid = new Cuboid(new Vertice3D(4, -2, -5), 4, 5, 6);
		
		Sphere sphere = new Sphere(new Vertice3D(4, 4, -12), 3.2);
		
		List<Shape> shapes = new ArrayList<Shape>();
		shapes.add(triangle);
		shapes.add(rectangle);
		shapes.add(circle);
		shapes.add(squarePyramid);
		shapes.add(cuboid);
		shapes.add(sphere);
		
		System.out.println("All shapes!");
		for (Shape shape : shapes) {
			System.out.println(shape);
		}
		System.out.println();
		
		System.out.println("Volume measurable with volume over 40!");
		shapes
			.stream()
			.filter(item -> item instanceof SpaceShape)
			.filter(item -> ((VolumeMeasurable) item).getVolume() > 40)
			.forEach(item -> System.out.println(item));
		System.out.println();
			
		System.out.println("Sorted and print Plane shapes!");	
		
		List<PlaneShape> planeShapes = shapes
				.stream()
				.filter(item -> item instanceof PlaneShape)
				.map(item -> (PlaneShape)item)
				.collect(Collectors.toList());
		planeShapes
			.sort((item1, item2) -> Double.compare(item1.getPerimeter(), item2.getPerimeter()));
		planeShapes.forEach(item -> System.out.println(item));
	}

}
