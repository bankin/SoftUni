package ponggame;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.util.Random;

public class Ball implements Runnable {
	//Global variables
	int x, y, xDirection, yDirection;
	int p1Score, p2Score;
	Rectangle ball;
	Paddle p1 = new Paddle(15, 140, 1);
	Paddle p2 = new Paddle(370, 140, 2);
	
	
	public Ball(int x, int y){
		this.x = x;
		this.y = y;
		this.p1Score = 0;
		this.p2Score = 0;
		
		//Set ball moving randomly
		Random r = new Random();
		int rDir = r.nextInt(1);
		if(rDir == 0){ rDir--;	}
		setXDirection(rDir);
		int yrDir = r.nextInt(1);
		if(yrDir == 0){ yrDir--; }
		setYDirection(yrDir);
		
		//Create the ball
		ball = new Rectangle(this.x, this.y, 7, 7);
	}
	
	public void setXDirection(int xDir){
		this.xDirection = xDir;
	}
	
	public void setYDirection(int yDir){
		this.yDirection = yDir;
	}
	
	public void draw(Graphics g){
		g.setColor(Color.WHITE);
		g.fillRect(this.ball.x, this.ball.y, this.ball.width, this.ball.height);
	}
	
	public void collision(){
		if(ball.intersects(p1.paddle)){
			setXDirection(+1);
		}
		if(ball.intersects(p2.paddle)){
			setXDirection(-1);
		}
	}
	
	public void move(){
		collision();
		ball.x += xDirection;
		ball.y += yDirection;
		
		//Bounce the ball when edge is detected
		if(ball.x <= 0){ setXDirection(+1); p2Score++; }
		if(ball.x >= 385) { setXDirection(-1); p1Score++; }
		if(ball.y <= 25){ setYDirection(+1); }
		if(ball.y >= 285) { setYDirection(-1); }
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
