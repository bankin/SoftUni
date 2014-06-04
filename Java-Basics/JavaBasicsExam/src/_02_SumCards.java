import java.util.Scanner;

// 2C 2H 2D AS 10H 10C 2S KD
// AS 10C KS KH KP 9H JH QS 3H QD QH 8S 10D 10S 7C JD
public class _02_SumCards {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		String[] cards = input.split(" ");
		int lastValue = 0;
		int sum = 0;
		int equalCount = 1;
		int value = 0;
		lastValue = getValue(cards[0]);
		if(cards.length == 1){
			System.out.println(lastValue);
			return;
		}
		for (int i = 1; i < cards.length; i++) {
			value = getValue(cards[i]);
			//System.out.println("Value = " + value);
			if(value == lastValue){
				equalCount++;
			}
			else{
				if(equalCount > 1){
					//System.out.println("Calc equal");
					//System.out.println(equalCount + " * " + lastValue + " * 2");
					sum += equalCount*lastValue*2;
					equalCount = 1;
				}
				else{
					//System.out.println("Calc");
					sum += lastValue;
				}
			}
			//System.out.println("Sum " + sum);
			if(i != cards.length - 1){
				lastValue = value;
			}
		}
		value = getValue(cards[cards.length - 1]);
		//System.out.println("Last value" + value);
		if(value == lastValue){
			sum += equalCount*value*2;
		}
		else{
			sum += value;
		}
		
		System.out.println(sum);
	}

	private static int getValue(String card) {
		String cardFace = extractFace(card);
		int value = 0;
		switch(cardFace){
			case "2": value = 2; break;
			case "3": value = 3; break;
			case "4": value = 4; break;
			case "5": value = 5; break;
			case "6": value = 6; break;
			case "7": value = 7; break;
			case "8": value = 8; break;
			case "9": value = 9; break;
			case "10": value = 10; break;
			case "J": value = 12; break;
			case "Q": value = 13; break;
			case "K": value = 14; break;
			case "A": value = 15; break;
		}
		
		return value;
	}

	private static String extractFace(String card) {
		String toReturn = "";
		for (int i = 0; i < card.length() - 1; i++) {
			toReturn += card.charAt(i);
		}
		
		return toReturn;
	}
}
