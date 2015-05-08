package geometry.shapes;

import geometry.vertices.Vertex;

import java.util.*;

public abstract class Shape {
	private List<Vertex> vertices;

	public Shape(Vertex ... vertices) {
		this.setVertices(new ArrayList<Vertex>(Arrays.asList(vertices)));
	}

	public List<Vertex> getVertices() {
		return vertices;
	}

	public void setVertices(List<Vertex> vertices) {	
		if (null == vertices) {
            throw new NullPointerException("The vertices list cannot be null.");
        }
		
		this.vertices = vertices;
	}

	@Override
	public String toString() {
		StringJoiner vertexJoiner = new StringJoiner(", ");
		for (Vertex vertex : getVertices()) {
			vertexJoiner.add(vertex.toString());
		}
		
		return getClass().getSimpleName() + ": {" + vertexJoiner.toString();
	}
	
	
	
}
