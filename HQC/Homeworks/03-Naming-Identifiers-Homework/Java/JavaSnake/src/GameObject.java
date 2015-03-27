import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

@SuppressWarnings("serial")
public class GameObject extends Canvas implements Runnable {
	public static SnakeObject snake;
	public static FoodObject food;
	static int points;
	
	private Graphics globalGraphics;
	private Thread runThread;
	public static final int WIDTH = 600;
	public static final int height = 600;
	private final Dimension windowSize = new Dimension(WIDTH, height);
	
	static boolean gameRunning = false;
	
	public void paint(Graphics g){
		this.setPreferredSize(windowSize);
		globalGraphics = g.create();
		points = 0;
		
		if(runThread == null){
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}
	
	public void run(){
		while(gameRunning){
			snake.tick();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
				// TODO: Handle exceptions
			}
		}
	}
	
	public GameObject(){	
		snake = new SnakeObject();
		food = new FoodObject(snake);
	}
		
	public void render(Graphics graphics){
		graphics.clearRect(0, 0, WIDTH, height+25);
		
		graphics.drawRect(0, 0, WIDTH, height);			
		snake.drawSnake(graphics);
		food.drawFoodObject(graphics);
		graphics.drawString("score= " + points, 10, height + 25);		
	}
}

