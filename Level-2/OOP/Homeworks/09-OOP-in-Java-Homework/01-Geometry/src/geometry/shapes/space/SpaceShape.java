package geometry.shapes.space;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;
import geometry.shapes.Shape;
import geometry.vertices.Vertex3D;

public abstract class SpaceShape extends Shape 
implements AreaMeasurable, VolumeMeasurable {
	
	public SpaceShape(Vertex3D ... vertices) {
	super(vertices);
	}

	public abstract double getVolume();

	public abstract double getArea();
	
	@Override
	public String toString() {
		return super.toString() + 
				String.format("; volume: %.2f; area: %.2f}", this.getVolume(), this.getArea());
	}
	
}
