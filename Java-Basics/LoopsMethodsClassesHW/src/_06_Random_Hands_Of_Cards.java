import java.util.Random;
import java.util.Scanner;

public class _06_Random_Hands_Of_Cards {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int rows = scan.nextInt();
		
		for (int i = 0; i < rows; i++) {
			printRandomHand();
		}
	}
	
	public static char generateCard(int value){
		String card = "";
		switch(value){
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7: 
			case 8:
			case 9: card = Integer.toString(value); break;
			case 10: card = "T"; break;
			case 11: card = "J"; break;
			case 12: card = "Q"; break;
			case 13: card = "K"; break;
			case 14: card = "A"; break;
		}
		return card.charAt(0);
	}

	public static void printRandomHand() {
		Random rand = new Random();
		for (int i = 0; i < 5; i++) {
			int card = rand.nextInt(13) + 2;
		}
		
	}
}
