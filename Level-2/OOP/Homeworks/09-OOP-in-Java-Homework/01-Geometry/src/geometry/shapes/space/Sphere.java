package geometry.shapes.space;

import geometry.vertices.Vertex3D;

public class Sphere extends SpaceShape {
	private double radius;

	public Sphere(Vertex3D vertex, double radius) {
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
	public double getVolume() {
		return 4 * Math.PI * Math.pow(this.getRadius(), 3) / 3;
	}

	@Override
	public double getArea() {
		return 4 * Math.PI * Math.pow(this.getRadius(), 2);
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
