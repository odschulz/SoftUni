package geometry.shapes.plane;

import geometry.vertices.Vertex2D;

public class Circle extends PlaneShape {
	
	private double radius;

	public Circle(Vertex2D vertex, double radius) {
		super(vertex);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	@Override
	public double getArea() {
		return Math.PI * Math.pow(this.getRadius(), 2);
	}

	@Override
	public double getPerimeter() {
		return 2 * Math.PI * this.getRadius();
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
