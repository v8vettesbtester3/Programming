package ex11;

public class ScentedCandle extends Candle {
	   private String scent;
	   public String getScent()
	   {
	      return scent;
	   }
	   public void setScent(String scent)
	   {
	      this.scent = scent;
	   }
	   @Override
	   public void setHeight(int ht)
	   {
	      final double PER_INCH = 3;
	      super.setHeight(ht);
	      price = ht * PER_INCH;
	   }
}
