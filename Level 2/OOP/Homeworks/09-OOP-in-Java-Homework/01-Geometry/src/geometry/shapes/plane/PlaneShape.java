package geometry.shapes.plane;

import geometry.interfaces.*;
import geometry.shapes.Shape;
import geometry.vertices.Vertex2D;

public abstract class PlaneShape extends Shape 
implements PerimeterMeasurable, AreaMeasurable {

	public PlaneShape(Vertex2D ... vertices) {
		super(vertices);
	}
	
	public abstract double getArea();

    public abstract double getPerimeter();
    
    @Override
	public String toString() {
		return super.toString() + 
				String.format("; perimeter: %.2f; area: %.2f}", this.getPerimeter(), this.getArea());
	}
}
