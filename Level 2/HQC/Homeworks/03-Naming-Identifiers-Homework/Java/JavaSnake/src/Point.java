import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class Point {
	private final int WIDTH = 20;
	private final int HEIGHT = 20;
	private int x, y;
	
	public Point(Point point){
		this(point.x, point.y);
	}
	
	public Point(int x, int y){
		this.x = x;
		this.y = y;
	}	
		
	public int getX() {
		return x;
	}
	public void setX(int x) {
		this.x = x;
	}
	public int getY() {
		return y;
	}
	public void setY(int y) {
		this.y = y;
	}
	
	public void drawSnake(Graphics graphics, Color color) {
		graphics.setColor(Color.BLACK);
		graphics.fillRect(x, y, WIDTH, HEIGHT);
		graphics.setColor(color);
		graphics.fillRect(x+1, y+1, WIDTH-2, HEIGHT-2);		
	}
	
	public String toString() {
		return "[x=" + x + ",y=" + y + "]";
	}
	
	public boolean equals(Object object) {
        if (object instanceof Point) {
            Point point = (Point)object;
            return (x == point.x) && (y == point.y);
        }
        return false;
    }
}
