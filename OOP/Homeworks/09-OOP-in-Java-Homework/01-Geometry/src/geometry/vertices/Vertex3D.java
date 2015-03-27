package geometry.vertices;

public class Vertex3D extends Vertex {

	private double z;
	
	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.setZ(z);
	}

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}
	
	@Override
	public double getDistanceTo(Vertex other) {
		if (!(other instanceof Vertex3D)) {
			throw new IllegalArgumentException(
					"Distance can be calculated only between vertices of the same type.");
		}
		
		double xDistance = other.getX() - this.getX();
		double yDistance = other.getY() - this.getY();
		double zDistance = ((Vertex3D) other).getZ() - this.getZ();
		double distance = Math.sqrt(
				Math.pow(xDistance, 2) + 
				Math.pow(yDistance, 2) + 
				Math.pow(zDistance, 2));
		return distance;
	}
	
	@Override
	public String toString() {
		return super.toString() + ", z = " + getZ() + ")";
	}

}
