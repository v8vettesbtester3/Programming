package ex11;

public class Candle {
	   private String color;
	   private int height;
	   protected double price;
	   public String getColor()
	   {
	      return color;
	   }
	   public int getHeight()
	   {
	      return height;
	   }
	   public double getPrice()
	   {
	      return price;
	   }
	   public void setColor(String clr)
	   {
	      color = clr;
	   }
	   public void setHeight(int ht)
	   {
	      final double PER_INCH = 2;
	      height = ht;
	      price = height * PER_INCH;
	   }
}
