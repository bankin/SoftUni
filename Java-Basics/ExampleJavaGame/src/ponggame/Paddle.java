package ponggame;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.KeyEvent;

public class Paddle implements Runnable{

	int x, y, yDirection,  id;
	
	Rectangle paddle;
	
	public Paddle(int x, int y, int id){
		this.x = x;
		this.y = y;
		this.id = id;
		
		paddle = new Rectangle(x, y, 10, 50);
	}
	
	public void keyPressed(KeyEvent e){
		int keyCode = e.getKeyCode();
		switch(id){
			default: System.out.println("Please enter valid id fpr paddle"); break;
			case 1:
				if(keyCode == e.VK_W){
					setYDirection(-1);
				}
				if(keyCode == e.VK_S){
					setYDirection(+1);
				}
			break;
			case 2:
				if(keyCode == e.VK_UP){	
					setYDirection(-1);
				}
				if(keyCode == e.VK_DOWN){
					setYDirection(+1);
				}
			break;
		}
	}
	
	public void keyReleased(KeyEvent e){
		int keyCode = e.getKeyCode();
		switch(id){
			default: System.out.println("Please enter valid id fpr paddle"); break;
			case 1:
				if(keyCode == e.VK_W){
					setYDirection(0);
				}
				if(keyCode == e.VK_S){
					setYDirection(0);
				}
			break;
			case 2:
				if(keyCode == e.VK_UP){	
					setYDirection(0);
				}
				if(keyCode == e.VK_DOWN){
					setYDirection(0);
				}
			break;
		}

	}
	
	public void setYDirection(int ydir){
		this.yDirection = ydir;
	}
	
	public void move(){
		paddle.y += yDirection;
		if(paddle.y < 25){ paddle.y = 25; }
		if(paddle.y > 250) { paddle.y = 250; }
	}
	
	public void draw(Graphics g){
		switch(id){
			default:System.out.println("Please enter a valid id for paddle"); break;
			case 1: 
				g.setColor(Color.CYAN);
				g.fillRect(paddle.x, paddle.y, paddle.width, paddle.height);
				break;
			case 2:
				g.setColor(Color.PINK);
				g.fillRect(paddle.x, paddle.y, paddle.width, paddle.height);
				break;
		}	
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		try {
			while(true){
				move();
				
				Thread.sleep(6);
			}
		} catch (Exception e) {
			System.err.println(e.getMessage());
		}
	}
	
}
