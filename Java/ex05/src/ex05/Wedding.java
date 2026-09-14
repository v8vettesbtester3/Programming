package ex05;

import java.time.*;

public class Wedding {
	LocalDate weddingDate;
	Couple weddingCouple;
	String weddingLocation;

	public Wedding(LocalDate weddingDate, Couple weddingCouple, String weddingLocation) {
		super();
		this.weddingDate = weddingDate;
		this.weddingCouple = weddingCouple;
		this.weddingLocation = weddingLocation;
	}
	
	public LocalDate getWeddingDate() {
		return weddingDate;
	}
	
	public Couple getWeddingCouple() {
		return weddingCouple;
	}
	
	public String getWeddingLocation() {
		return weddingLocation;
	}
}
