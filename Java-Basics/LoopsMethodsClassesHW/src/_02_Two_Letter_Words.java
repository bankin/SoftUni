import java.util.Scanner;


public class _02_Two_Letter_Words {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Input symbols ");
		String letters = scan.nextLine();
		
		for (int i = 0; i < letters.length(); i++) {
			for (int j = 0; j < letters.length(); j++) {
				for (int k = 0; k < letters.length(); k++) {
					System.out.print(letters.charAt(i) + "" + letters.charAt(j) + "" + letters.charAt(k) + " ");
				}
			}
		}
	}
}
