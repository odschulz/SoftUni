package geometry.shapes.space;

import geometry.vertices.Vertex3D;

public class SquarePyramid extends SpaceShape {
	
	double baseWidth, height;
	

	public SquarePyramid(Vertex3D baseCenter, double baseWidth, double height) {
		super(baseCenter);
		this.setBaseWidth(baseWidth);
		this.setHeight(height);
	}
	
	public double getBaseWidth() {
		return baseWidth;
	}

	public void setBaseWidth(double baseWidth) {
		this.baseWidth = baseWidth;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double getVolume() {
		double volume = Math.pow(this.getBaseWidth(), 2) * (this.getHeight() / 3);
		
		return volume;
	}

	@Override
	public double getArea() {
		double area = 
				Math.pow(this.getBaseWidth(), 2)
                + this.getBaseWidth() * 2
                * Math.sqrt(Math.pow(this.getBaseWidth(), 2) / 4 
                		+ Math.pow(this.getHeight(), 2));
		
        return area;
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
