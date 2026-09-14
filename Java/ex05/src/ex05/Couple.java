package ex05;

public class Couple {
	Person partnerLeft;
	Person partnerRight;
	
	public Couple(Person partnerLeft, Person partnerRight) {
		super();
		this.partnerLeft = partnerLeft;
		this.partnerRight = partnerRight;
	}
	
	public Person getPartnerLeft() {
		return partnerLeft;
	}
	
	public Person getPartnerRight() {
		return partnerRight;
	}
}
