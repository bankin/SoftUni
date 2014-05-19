package gamePart;

import java.awt.Image;
import java.awt.Rectangle;
import java.util.ArrayList;

import javax.swing.ImageIcon;

public class Aliens {

	private String alien = "karakacil_probi1112.png";
	private int x;
	private int y;
	private int width;
	private int height;
	private Image image;
	private boolean visibale;
	public  Aliens(int x, int y){
		ImageIcon ii = new ImageIcon(this.getClass().getResource(alien));
		image = ii.getImage();
		width = image.getWidth(null);
		height = image.getHeight(null);
		visibale = true;
		this.x = x;
		this.y = y;
	}
	public void move(){
		y++;
		if(y>=500){
			setVisible(false);
		}
	}
	public int getX(){
		return  this.x;
	}
	public int getY(){
		return this.y;
	}
	public Image getImage(){
		return image;
	}
	public Rectangle getBounds(){
		return new Rectangle(x,y,width,height);
	}
	public void setVisible(Boolean v) {
		this.visibale = v;
	}
	public boolean isVisible(){
		return this.visibale;
	}
}
