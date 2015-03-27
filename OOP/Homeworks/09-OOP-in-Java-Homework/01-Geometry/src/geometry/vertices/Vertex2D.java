package geometry.vertices;

public class Vertex2D extends Vertex {
	
	public Vertex2D(double x, double y) {
		super(x, y);
	}

	@Override
	public double getDistanceTo(Vertex other) {
		if (!(other instanceof Vertex2D)) {
			throw new IllegalArgumentException(
					"Distance can be calculated only between vertices of the same type.");
		}
		double xDistance = other.getX() - this.getX();
		double yDistance = other.getY() - this.getY();
		double distance = Math.sqrt(Math.pow(xDistance, 2) + Math.pow(yDistance, 2));
		return distance;
	}
	
	@Override
	public String toString() {
		return super.toString() + ")";
	}

}
