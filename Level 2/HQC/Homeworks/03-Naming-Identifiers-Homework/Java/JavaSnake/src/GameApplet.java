import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

@SuppressWarnings("serial")
public class GameApplet extends Applet {
	private GameObject game;
	Controls IH;
	
	public void init(){
		game = new GameObject();
		game.setPreferredSize(new Dimension(800, 650));
		game.setVisible(true);
		game.setFocusable(true);
		this.add(game);
		this.setVisible(true);
		this.setSize(new Dimension(800, 650));
		IH = new Controls(game);
	}
	
	public void paint(Graphics graphics){
		this.setSize(new Dimension(800, 650));
	}

}
