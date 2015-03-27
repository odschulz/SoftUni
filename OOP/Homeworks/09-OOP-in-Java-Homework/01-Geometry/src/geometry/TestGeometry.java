package geometry;

import java.util.ArrayList;

import geometry.interfaces.*;
import geometry.shapes.Shape;
import geometry.shapes.plane.*;
import geometry.shapes.space.*;
import geometry.vertices.*;

public class TestGeometry {

	public static void main(String[] args) {
		
		Triangle triangle = new Triangle(
				new Vertex2D(3, 5),
				new Vertex2D(5, -6),
				new Vertex2D(17, -9));
		
		Rectangle rectangle = new Rectangle(new Vertex2D(5,  9), 7, 15);
		
		Circle circle = new Circle(new Vertex2D(3, 5), 5);
		
		SquarePyramid squarePyramid = new SquarePyramid(new Vertex3D(1, 8, 5.9), 5, 8);
		
		Cuboid cuboid = new Cuboid(new Vertex3D(7, 8, 6), 1, 2.5, 5.3);
		
		Sphere sphere = new Sphere(new Vertex3D(5.4, 9, -2), 7);

		ArrayList<Shape> shapes = new ArrayList<Shape>() {{
			add(triangle);
			add(rectangle); 
			add(circle);
			add(squarePyramid); 
			add(cuboid);
			add(sphere); 
		}};
		
		for (Shape shape : shapes) {
			System.out.println(shape);
		}
		
		System.out.println("\nShapes that implement VolumeMeasurable and have volume over 40:\n");
		
		shapes.stream()
		.filter(s -> s instanceof VolumeMeasurable)
		.filter(s -> ((VolumeMeasurable) s).getVolume() > 40)
		.forEach(s -> System.out.println(s.toString()));
		
		System.out.println("\nPlane Shapes sorted by perimeter in ascending order:\n");
		
		shapes.stream().
        filter(s -> s instanceof PlaneShape)
        .sorted((s1, s2) -> 
        	Double.compare(((PerimeterMeasurable) s1).getPerimeter(), ((PerimeterMeasurable) s2).getPerimeter())).
        forEach(s -> System.out.println(s.toString()));
	}

}
