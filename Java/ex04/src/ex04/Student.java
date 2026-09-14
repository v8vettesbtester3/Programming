package ex04;

public class Student {
    private int idNumber;
    private int hours;
    private int points;
    
    
    
	public Student(int idNumber, int hours, int points) {
		super();
		this.idNumber = idNumber;
		this.hours = hours;
		this.points = points;
	}
	
	public Student() {
		super();
		idNumber = 9999;
		hours = 3;
		points = 12;
	}

	public int getIdNumber() {
		return idNumber;
	}
	public void setIdNumber(int idNumber) {
		this.idNumber = idNumber;
	}
	public int getHours() {
		return hours;
	}
	public void setHours(int hours) {
		this.hours = hours;
	}
	public int getPoints() {
		return points;
	}
	public void setPoints(int points) {
		this.points = points;
	}
	
	// methods to display the fields

	public void showIDnumber() {
		System.out.println("ID Number is: " + idNumber);
	}

	public void showHours() {
		System.out.println("Credit Hours: " + hours);
	}

	public void showPoints() {
		System.out.println("Points Earned: " + points);
	}

	public double getGradePoint() {
		return (points * 1.0 / hours);
		// simple integer division will truncate the decimal places
	}

}
