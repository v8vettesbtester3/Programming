package ex05;

import java.time.*;

public class Person {
	private String firstName;
	private String lastName;
	private LocalDate birthdate;
	
	public Person(String firstName, String lastName, LocalDate birthdate) {
		super();
		this.firstName = firstName;
		this.lastName = lastName;
		this.birthdate = birthdate;
	}
	
	public String getFirstName() {
		return firstName;
	}
	
	public String getLastName() {
		return lastName;
	}
	
	public LocalDate getBirthdate() {
		return birthdate;
	}
}
