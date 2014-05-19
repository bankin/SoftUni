package ZiostSpaceInvaders;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

import javax.swing.ImageIcon;
import javax.swing.JFrame;

import ponggame.Main.AL;

public class Game extends JFrame  {
	Image dbImage;
	Graphics dbg;
	
	public static int Width = 500;
	public static int Height = 600;
	public static Board board;
	public Game(){		
		setTitle("Crusher");
		setSize(Width,Height);
		setResizable(false);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBackground(Color.DARK_GRAY);	
		addKeyListener(new AL());
	}
	
	public class AL extends KeyAdapter {
			
		@Override
		public void keyPressed(KeyEvent e){
			board.player.keyPressed(e);
		}
		
		@Override
		public void keyReleased(KeyEvent e){
			board.player.keyReleased(e);
		}
	}
	
	@Override
	public void paint(Graphics g){
		dbImage = createImage(getWidth(), getHeight());
		dbg = dbImage.getGraphics();
		draw(dbg);
		g.drawImage(dbImage, 0, 0, this);
	}
	
	public void draw(Graphics g){
		board.draw(g);
		board.player.draw(g);
		
		repaint();
	}
	
	public static void main(String[] args) {
		Game game = new Game();
		
		board = new Board();
		Thread b1 = new Thread(board);
		Thread p1 = new Thread(board.player);
		
		b1.start();
		p1.start();
	}
}
