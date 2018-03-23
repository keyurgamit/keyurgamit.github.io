import java.applet.*;
import java.awt.*;
import java.util.*;


public class testdemo extends Applet implements Runnable
{
Thread t;
String str="";

public void init()
{
setBackground(Color.cyan);
setForeground(Color.blue);
setFont(new Font("Arial",Font.BOLD,40));
t=new Thread(this);
t.start();
}

public void run()
{
while(true)
{
Date d=new Date();
int h=d.getHours();
int m=d.getMinutes();
int s=d.getSeconds();
str=h+":"+m+":"+s;
repaint();

try
{
t.sleep(1000);
}
catch(InterruptedException e)
{
	
}

}

}
public void paint(Graphics g)
{
g.drawString(str,100,100);
}
}
