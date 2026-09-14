package ex05;

import java.time.*;

public class FitnessTracker {
	   String activity;
	   int minutes;
	   LocalDate date;

	   public FitnessTracker()
	   {
	      this("running", 0, LocalDate.of(2024, 1, 1));
	   }

	   public FitnessTracker(String activityParam, int minutesParam, LocalDate dateParam)
	   {
	      activity = activityParam;
	      minutes = minutesParam;
	      date = dateParam;
	   }
	   
	   public String getActivity()
	   {
	      return activity;
	   }
	   
	   public int getMinutes()
	   {
	      return minutes;
	   }
	   
	   public LocalDate getDate()
	   {
	      return date;
	   }
}
