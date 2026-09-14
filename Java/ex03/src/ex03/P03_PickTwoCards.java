/*
 * Java 03, Ex 03
 * 
 * Write a Java program that has a second class, named Card.  
 * Design the Card class to contain a character data field to 
 * hold the suit of a playing card 
 * (s for spades, h for hearts, c for clubs, d for diamonds) 
 * and an integer data field for a value from 1 to 13.  
 * Include get and set methods for each field.  
 * Save the class as Card.java.
 * 
 * Write an application that randomly selects 
 * two playing cards and displays their values. 
 * Randomly pick the suit and randomly pick the value.  
 * Use the Math.random() function.  
 * Display the two cards and determine whether the first is 
 * greater or less than the second.
 * 
 * J. M. Hinckley
 * 2024
 */
package ex03;

public class P03_PickTwoCards {

	   public static void main(String[] args)
	   {
	      final int CARDS_IN_SUIT = 13;
	      int myValue;    
	      int yourValue;
	      Card myCard = new Card();
	      Card yourCard = new Card();
	      myValue = ((int)(Math.random() * 100) % CARDS_IN_SUIT + 1);
	      yourValue = ((int)(Math.random() * 100) % CARDS_IN_SUIT + 1);
	      myCard.setValue(myValue);
	      yourCard.setValue(yourValue);
	      myCard.setSuit('s');
	      yourCard.setSuit('h');
	      System.out.println("My card is the " 
	    		  + myCard.getValue() 
	    		  + " of " + myCard.getSuit());
	      System.out.println("Your card is the " 
	    		  + yourCard.getValue() + " of " 
	    		  + yourCard.getSuit());
	      
	      if (myCard.getValue() > yourCard.getValue()) {
	    	  System.out.println("The value of my card is greater than yours.");
	      }
	      else if (myCard.getValue() < yourCard.getValue()) {
	    	  System.out.println("The value of my card is less than yours.");
	      }
	      else {
	    	  System.out.println("Our cards have the same value.");
	      }
	   }

}
