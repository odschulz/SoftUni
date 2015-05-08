import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class FoodObject {
	public static Random randomGenerator;
	private Point foodObject;
	private Color snakeColor;
	
	public FoodObject(SnakeObject snake) {
		foodObject = createFoodObject(snake);
		snakeColor = Color.RED;		
	}
	
	private Point createFoodObject(SnakeObject snake) {
		randomGenerator = new Random();
		int x = randomGenerator.nextInt(30) * 20; 
		int y = randomGenerator.nextInt(30) * 20;
		for (Point snakePoint : snake.snakeBody) {
			if (x == snakePoint.getX() || y == snakePoint.getY()) {
				return createFoodObject(snake);				
			}
		}
		return new Point(x, y);
	}
	
	public void drawFoodObject(Graphics graphics){
		foodObject.drawSnake(graphics, snakeColor);
	}	
	
	public Point getPoint(){
		return foodObject;
	}
}
