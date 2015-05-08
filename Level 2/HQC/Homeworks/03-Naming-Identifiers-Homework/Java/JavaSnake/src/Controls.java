import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class Controls implements KeyListener {
	
	public Controls(GameObject game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent event) {
		int keyCode = event.getKeyCode();
		
		if (keyCode == KeyEvent.VK_W || keyCode == KeyEvent.VK_UP) {
			if(GameObject.snake.getVelY() != 20){
				GameObject.snake.setVelX(0);
				GameObject.snake.setVelY(-20);
			}
		}
		if (keyCode == KeyEvent.VK_S || keyCode == KeyEvent.VK_DOWN) {
			if(GameObject.snake.getVelY() != -20){
				GameObject.snake.setVelX(0);
				GameObject.snake.setVelY(20);
			}
		}
		if (keyCode == KeyEvent.VK_D || keyCode == KeyEvent.VK_RIGHT) {
			if(GameObject.snake.getVelX() != -20){
			GameObject.snake.setVelX(20);
			GameObject.snake.setVelY(0);
			}
		}
		if (keyCode == KeyEvent.VK_A || keyCode == KeyEvent.VK_LEFT) {
			if(GameObject.snake.getVelX() != 20){
				GameObject.snake.setVelX(-20);
				GameObject.snake.setVelY(0);
			}
		}
		//Other controls
		if (keyCode == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
