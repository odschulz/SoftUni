package geometry.shapes.plane;

import geometry.vertices.Vertex2D;

public class Rectangle extends PlaneShape {
	
	private double width, height;
	
	public Rectangle(Vertex2D v1, double width, double height) {
		super(v1);
		this.setWidth(width);
		this.setHeight(height);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double getArea() {
		return this.getWidth() * this.getHeight();
	}

	@Override
	public double getPerimeter() {
		return  2 * this.getWidth() + 2 * this.getHeight();
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
