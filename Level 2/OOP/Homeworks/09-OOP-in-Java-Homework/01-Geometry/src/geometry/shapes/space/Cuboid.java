package geometry.shapes.space;

import geometry.vertices.Vertex3D;

public class Cuboid extends SpaceShape {
	
	double width, height, depth;

	public Cuboid(Vertex3D vertex, double width, double height,
			double depth) {
		super(vertex);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
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

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		this.depth = depth;
	}

	@Override
	public double getVolume() {
		return this.getHeight() * this.getWidth() * this.getDepth();
	}

	@Override
	public double getArea() {
		double area = 
				(this.getWidth() * this.getHeight()) * 2
				+ (this.getHeight() * this.getDepth()) * 2
				+ (this.getWidth() * this.getDepth()) * 2;
		
		return area;
	}
	
	@Override
	public String toString() {
		return super.toString();
	}
	
}
