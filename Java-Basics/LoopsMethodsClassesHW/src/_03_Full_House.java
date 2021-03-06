import java.util.ArrayList;


public class _03_Full_House {
	
	public static boolean checkFullHouse(String cards){
		if(cards.charAt(0) == cards.charAt(1) && cards.charAt(0) == cards.charAt(2)){
			if(cards.charAt(3) == cards.charAt(4)){
				if(cards.charAt(0) != cards.charAt(3)){
					return true;
				}
			}
		}
		return false;
	}
	
	public static void generateSuits(String cards){
		
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
	
	public static void main(String[] args) {
		ArrayList<String> allHands = new ArrayList<String>();
		int count = 0;
		for (int i = 2; i < 15; i++) {
			for (int j = 2; j < 15; j++) {
				for (int k = 2; k < 15; k++) {
					for (int l = 2; l < 15; l++) {
						for (int m = 2; m < 15; m++) {
							String currCardHand = "";
							currCardHand += generateCard(i);
							currCardHand += generateCard(j);
							currCardHand += generateCard(k);
							currCardHand += generateCard(l);
							currCardHand += generateCard(m);
							
							if(!allHands.contains(currCardHand)){
								allHands.add(currCardHand);
								if(checkFullHouse(currCardHand)){
									count++;
									generateSuits(currCardHand);
								}
							}													
						}
					}
				}
			}
		}
		System.out.println("Done with all " + count + " pairs");
		
	}
}
