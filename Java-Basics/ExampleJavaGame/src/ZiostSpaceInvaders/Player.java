package ZiostSpaceInvaders;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.KeyEvent;
import java.util.ArrayList;

public class Player implements Runnable{

	private static final int MAX_BULLETS = 5;
	int x, y, xDirection,  id;
    int bx, by;
    boolean readyToFire, shot = false;
    
    ArrayList<Rectangle> bullets;
    
    public Player(){
    	readyToFire = true;
        x = 175;
        y = 575;
        bullets = new ArrayList<Rectangle>();
    }
    
    public void draw(Graphics g){
        g.setColor(Color.BLUE);
        g.fillRect(x, y, 40, 10);
        g.fillRect(x+18, y-7, 4, 7);
        
        //if(shot){        	
        	g.setColor(Color.BLACK);
        	for (int i = 0; i < bullets.size(); i++) {
        		g.fillRect(bullets.get(i).x, bullets.get(i).y, bullets.get(i).width, bullets.get(i).height);
			}        	
        //}        
    }
    
    public Rectangle getBounds(){
    	return new Rectangle(x, y, 40, 10);
    }
    
    public void shoot(){
    //	if(shot){
    		for (int i = 0; i < bullets.size(); i++) {
				bullets.get(i).y--;
			}    		
    //	}
    }
    
    public void move(){
        x += xDirection;
        if(x <= 0)
            x = 0;
        if(x >= 360)
            x = 360;
    }
    
    public void keyPressed(KeyEvent e){
        int keyCode = e.getKeyCode();
        if(keyCode == e.VK_LEFT){
            setXDirection(-1);
        }
        if(keyCode == e.VK_RIGHT){
            setXDirection(1);
        }
        if(keyCode==e.VK_SPACE){      
        	if(bullets.size() < MAX_BULLETS){
        		//readyToFire = true;
        	}
        	if(readyToFire){
        		by = y - 7;
        		bx = x + 18;
        		Rectangle bullet = new Rectangle(bx, by, 3, 5);
        		bullets.add(bullet);
        	//	shot = true;
        	}
        }
    }
    public void keyReleased(KeyEvent e){
        int keyCode = e.getKeyCode();
        if(keyCode == e.VK_LEFT){
            setXDirection(0);
        }
        if(keyCode == e.VK_RIGHT){
            setXDirection(0);
        }
        if(keyCode==e.VK_SPACE){
    		//readyToFire = false;
    		for (int i = 0; i < bullets.size(); i++) {
    			if(bullets.get(i).y < -5){
        			bullets.remove(i);
        			//shot = false;
        			//readyToFire = true;
        		}
			}
        }
    }
	
	public Player(int x, int y ){
		this.x = x;
		this.y = y;
	}
	
	public void setXDirection(int xdir){
		this.xDirection = xdir;
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		try {
			while(true){
				shoot();
				move();
				
				Thread.sleep(7);
			}
		} catch (Exception e) {
			System.err.println(e.getMessage());
		}
	}
	
}
