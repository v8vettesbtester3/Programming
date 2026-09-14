// Contestant Number here...

// Create AI Chatbots
// test market for which chatbots are most popular and 
// which token rate is the most profitable

package bpa_rlc_2025;

import java.util.*;
import java.text.DecimalFormat;

public class AIChatBotGenerator_Regional {
	
	static Scanner sc = new Scanner(System.in);	// SC1
	static DecimalFormat df_Currency = new DecimalFormat("#,##0.00");	// SC7

	public static void main(String[] args) {
		ArrayList<Chatbots> bots = new ArrayList<Chatbots>();	// SC2
		System.out.println("How many test bots do you want to create?");
		int numberOfBots = integerInputManager();
		
		// SC3
		String[] languages = {"English", "French", "Chinese", "Spanish", "Arabic", "Russian", 
				"German", "Japanese", "Portuguese", "Hindi", "Italian", "Korean", "Turkish", 
				"Vietnamese", "Indonesian", "Greek", "Hebrew", "Thai"};
		
		bots = setChatbots(bots, languages, numberOfBots);
		printChatbots(bots, df_Currency);
	}
	
	private static String[][] compatibleLanguagePairs = {
			{"English", "Spanish"}, {"English", "French"}, {"English", "German"}, {"Japanese", "English"},
			{"Japanese", "Hindi"}, {"Portuguese", "French"}, {"Spanish", "Portuguese"}, {"Spanish", "Italian"},
			{"French", "Italian"},{"Russian", "Chinese"}, { "Russian", "Korean"}, { "Russian", "Japanese"},
			{"Russian", "German"}, { "Hindi", "Arabic"},{"Japanese", "Korean"}, { "Russian", "Arabic"},
			{"Spanish", "Arabic"},{"Russian", "French"},{"Chinese", "Korean"},{"Japanese", "Vietnamese"},
			{"Arabic", "Hebrew"}, { "Greek", "Hebrew"},{"Arabic", "Indonesian"},{"Russian", "Indonesian"},
			{ "Chinese", "Thai"},{"Japanese", "Vietnamese"}, {"English", "Chinese"}, { "Japanese", "Thai"}, 
			{"Indonesian", "Thai"},{"Chinese", "Spanish"}, {"Arabic", "Turkish"}, { "Greek", "Turkish"},
			{"Vietnamese", "Thai"},{"Vietnamese", "French"},{"Vietnamese", "Indonesian"},{"Turkish", "Spanish"}
	};

	// This will create the random bots
	private static ArrayList<Chatbots> setChatbots (ArrayList<Chatbots> list_of_Bots, String[] languages, int noB) { 
		Random rand = new Random(); // SC6
		Chatbots chatBots;
		ArrayList<Chatbots> bots = list_of_Bots;
		DecimalFormat df = new DecimalFormat("#.0000");
		int numberOfBots = noB;
		double tokenRate;
		int complexity; String primaryLang;
		String secondaryLang;
		for (int i = 0; i < numberOfBots; i++) {
			do {  // SC8  *** This is not shown in the distributed key
				primaryLang = languages[rand.nextInt(languages.length)];
				secondaryLang = languages[rand.nextInt(languages.length)];
			} while (primaryLang.equals(secondaryLang));
			complexity = rand.nextInt(16) + 1; // SC9 *** This is not shown in the distributed key & improperly designated in rubric
			double tempTokenRate = rand.nextDouble() * 7.5 + 0.1; // SC10 *** This is not shown in the distributed key & improperly designated in rubric

			String tempString = df.format(tempTokenRate); // SC12 *** This is not shown in the distributed key & improperly designated in rubric
			tokenRate = Double.parseDouble(tempString);
			chatBots = new Chatbots(primaryLang, secondaryLang, complexity, tokenRate);
			bots.add(chatBots);
		}
		return bots;
	}

	private static boolean isCompatible(String primaryLang, String secondaryLang) { //SC15 
		for (String[] pair: compatibleLanguagePairs) {
			if ((pair[0].equals (primaryLang) && pair[1].equals(secondaryLang)) || (pair[1].equals(primaryLang) && pair[0].equals(secondaryLang))) {
				return true;
			}
		}
		return false;
	}
	
	private static void printChatbots (ArrayList<Chatbots> bots, DecimalFormat df_Currency) {  // SC11
		System.out.println("-------------------------------------------------------------------------------------------------------------------");
		System.out.printf("| %-4s | %-15s | %-15s | %-20s | %-10s | %-15s | %-14s |\n", //SC13
		"No.", "Primary Lang.", "Secondary Lang.", "Algorithm Complexity", "TokenRate", "Estimated Cost", "Compatibility"); 
		System.out.println("-------------------------------------------------------------------------------------------------------------------");
		int i = 1;
		for (Chatbots b: bots) {
			String compatibility = isCompatible (b.getPrimaryLanguage(), b.getSecondaryLanguage()) ? "Compatible" : "Not Compatible"; 
			System.out.printf("| %-4d | %-15s | %-15s | %-20d | %-10.2f | $%-14s | %-14s |\n", //SC14
					i, b.getPrimaryLanguage(), b.getSecondaryLanguage(), b.getComplexity(), b.getTokenRate(), df_Currency.format(b.getEstimatedCost()), compatibility);
			i++;
		}
		System.out.println("-------------------------------------------------------------------------------------------------------------------");
		}

		private static int integerInputManager() {
			int temp;
			while (true) {
				try { // SC4
					do {
						System.out.print("Please enter in a value between 5 and 20: ");
						temp = sc.nextInt();
						if (temp > 20 || temp < 5) // SC5
							System.out.println("Your entry is out of range. \n");
						sc.nextLine();
					} while (temp > 20 || temp < 5); // SC5
					return temp;
				} catch (InputMismatchException e) // SC4
				{
					sc.next();
					System.out.println("\nPlease enter a correct value.");
				}
			}
		}
	}

//Given
/////////////////////////////////////////////////
class Chatbots {
	String primaryLang;
	String secondaryLang;
	int complexity_Level;
	double tokenRate;
	double estimatedCost = 0;
	
	public Chatbots()
	{
		primaryLang = "ASCII";
		secondaryLang = "ASCII";
		complexity_Level = 0;
		tokenRate = 0.0;
	}

	public Chatbots(String primaryLang, String secondaryLang, int complexity_Level, double tokenRate) {
		super();
		this.primaryLang = primaryLang;
		this.secondaryLang = secondaryLang;
		this.complexity_Level = complexity_Level;
		this.tokenRate = tokenRate;
		setEstimatedCost();
	}

	public String getPrimaryLanguage() {
		return primaryLang;
	}

	public String getSecondaryLanguage() {
		return secondaryLang;
	}

	public int getComplexity() {
		return complexity_Level;
	}

	public double getTokenRate() {
		return tokenRate;
	}

	public double getEstimatedCost() {
		return estimatedCost;
	}
	
	public void setEstimatedCost() {
		estimatedCost = getComplexity() * getTokenRate();
	}
}
