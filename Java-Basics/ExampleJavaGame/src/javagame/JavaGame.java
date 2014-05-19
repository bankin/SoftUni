package javagame;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Rectangle;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.File;

import javax.swing.ImageIcon;
import javax.swing.JFrame;

public class JavaGame extends JFrame implements Runnable{
	int x,y, xDirection, yDirection;
	private Image dbImage;
	private Graphics dbg;
	
	Image face;
	Font font = new Font("Arial", Font.BOLD, 30);
	public int rectY;
	public int rectX;
	
	public void run(){
		try {
			while(true){
				
				move();
				Thread.sleep(5);
			}
		} catch (Exception e) {
			System.out.println("Error");
		}
	}
	
	public void move(){
		x += xDirection;
		y += yDirection;
		
		if (x < 0) { x = 0;}
		if (x > 470) { x = 470; }
		if (y < 0) { y = 0; }
		if (y > 470) { y = 470; }
	}
	
	public void setXDirection(int xdir){
		xDirection = xdir;
	}
	
	public void setYDirection(int ydir){
		yDirection = ydir;
	}
	
	public class AL extends MouseAdapter {
		
		@Override
		public void mouseMoved(MouseEvent e){
			rectX = e.getX() - 12;
			rectY = e.getY() - 12;
		}
		
		
//		If you want this working make the class AL extends KeyAdapter		
//		public void keyPressed(KeyEvent e){
//			int keyCode = e.getKeyCode();
//			
//			if(keyCode == e.VK_LEFT){
//				setXDirection(-1);
//			}
//			if(keyCode == e.VK_RIGHT){
//				setXDirection(+1);
//			}
//			if(keyCode == e.VK_UP){
//				setYDirection(-1);
//			}
//			if(keyCode == e.VK_DOWN){
//				setYDirection(+1);
//			}	
//		}
//		
//		public void keyReleased(KeyEvent e){
//			int keyCode = e.getKeyCode();
//			
//			if(keyCode == e.VK_LEFT){
//				setXDirection(0);
//			}
//			if(keyCode == e.VK_RIGHT){
//				setXDirection(0);
//			}
//			if(keyCode == e.VK_UP){
//				setYDirection(0);
//			}
//			if(keyCode == e.VK_DOWN){
//				setYDirection(0);
//			}		
//		}
	}
	
	public JavaGame(){
		//Load
		ImageIcon i = new ImageIcon(System.getProperty("user.home") + File.separator + "Desktop" + File.separator +"smile.png");
		face = i.getImage();
				
		//Game
		addMouseMotionListener(new AL());
		setTitle("JavaGame");
		setSize(500,500);
		setResizable(false);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBackground(Color.GREEN);
		x = 150;
		y = 150;
	}
	
	public void paint(Graphics g){
		dbImage = createImage(getWidth(), getHeight());
		dbg = dbImage.getGraphics();
		paintComponent(dbg);
		g.drawImage(dbImage, 0, 0, this);
	}
	
	public void paintComponent(Graphics g){
		Rectangle r1 = new Rectangle(rectX, rectY, 25, 25);
		Rectangle r2 = new Rectangle(175, 75, 50, 50);
		
		g.setColor(Color.RED);
		g.fillRect(r2.x, r2.y, r2.width, r2.height);
		g.setColor(Color.BLUE);
		g.fillRect(r1.x, r1.y, r1.width, r1.height);
		
		//Colission
		if(r1.intersects(r2)){
			g.drawString("Colision", 175, 75);
		}
		
		repaint();
	}
	
	public static void main(String[] args) {
		JavaGame game = new JavaGame();
		
		Thread t1 = new Thread(game);
		t1.start();
	}
}
