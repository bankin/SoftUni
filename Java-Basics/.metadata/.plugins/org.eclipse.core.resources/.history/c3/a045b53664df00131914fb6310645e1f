package gamePart;
import javax.swing.ImageIcon;
import javax.swing.JFrame;

import java.awt.Color;
import java.awt.Image;

public class Game extends JFrame  {
	public static int Width = 500;
	public static int Height = 600;
	public Game(){
		String alien = "karakacil_probi1112.png";
		Image im;
		ImageIcon ii = new ImageIcon(this.getClass().getResource(alien));
		im = ii.getImage();
		setTitle("Crusher");
		setSize(Width,Height);
		setResizable(false);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBackground(Color.DARK_GRAY);
		System.out.println("Start the game");
		add(new Board());	
	}
	public static void main(String[] args) {
		new Game();
		
	}
}
