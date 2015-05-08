package geometry.shapes.plane;

import geometry.vertices.Vertex2D;

public class Triangle extends PlaneShape {
	
	private double sideAB, sideBC, sideCA;

	public Triangle(Vertex2D v1, Vertex2D v2, Vertex2D v3) {
		super(v1, v2, v3);
		this.sideAB = v1.getDistanceTo(v2);
		this.sideBC = v2.getDistanceTo(v3);
		this.sideCA = v3.getDistanceTo(v1);
		
		if ((sideAB + sideBC <= sideCA) || 
				(sideBC + sideCA <= sideAB) || 
				(sideCA + sideAB <= sideBC)) {
			throw new IllegalArgumentException("A triangle cannot be created with these vertices.");
		}
	}

	@Override
	public double getArea() {
		double halfPerimeter = getPerimeter() / 2;
		double area = Math.sqrt(halfPerimeter 
				* (halfPerimeter - this.sideAB)
				* (halfPerimeter - this.sideBC)
				* (halfPerimeter - this.sideCA));
		
		return area;
	}

	@Override
	public double getPerimeter() {
		return this.sideAB + this.sideBC + this.sideCA;
	}
	
	@Override
	public String toString() {
		return super.toString();
	}

}
