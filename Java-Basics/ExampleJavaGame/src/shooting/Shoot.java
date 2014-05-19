package shooting;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Shoot extends JFrame {
    
    private Image dbImage;
    private Graphics dbg;
    
    static Ship s1 = new Ship();
        
    public Shoot(){
        setSize(400,300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);
        setVisible(true);
        addKeyListener(new AL());
    }
    
    @Override
    public void paint(Graphics g){
        dbImage = createImage(getWidth(), getHeight());
        dbg = dbImage.getGraphics();
        paintComponent(dbg);
        g.drawImage(dbImage, 0, 0, this);
    }
    public void paintComponent(Graphics g){
        //Draw the ship
        s1.draw(g);
                
        repaint();
    }
    
    public class AL extends KeyAdapter {
        @Override
        public void keyPressed(KeyEvent e){
            s1.keyPressed(e);
        }
        @Override
        public void keyReleased(KeyEvent e){
            s1.keyReleased(e);
        }
    }
    
    public static void main(String[] args) {
        Shoot shoot = new Shoot();
        //Threads
        Thread ship = new Thread(s1);
        ship.start();
    }
}