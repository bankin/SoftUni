import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;


public class _01_StuckNumbers {
	private static boolean print = false;

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int count = Integer.parseInt(scan.nextLine());
		String[] numbers = scan.nextLine().split(" ", -1);
		if(count < 4){ System.out.println("No"); return; }
		HashMap<String, String> couples = new HashMap<String, String>();
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers.length; j++) {
				if(i != j){
					String value = numbers[i]+""+numbers[j];
					String key = numbers[i]+"|"+numbers[j];
					checkForCouples(couples, key, value);
					couples.put(key,value);
				}
			}
		}
		
		if(!print){
			System.out.println("No");
		}
	}

	private static void checkForCouples(HashMap<String, String> couples,
			String valueKey, String value) {
		Iterator<String> keySetIterator = couples.keySet().iterator();

		while(keySetIterator.hasNext()){
			String key = keySetIterator.next();
			if(couples.get(key).equals(value)){
				if(!equalCouples(key, valueKey)){
					System.out.println(valueKey+"=="+key);
					System.out.println(key+"=="+valueKey);
					print = true;							
				}
			}		
		}
	}

	private static boolean equalCouples(String string, String value) {
		String[] first = string.replace('|', ' ').split(" ");
		String[] second = value.replace('|', ' ').split(" ");					

		return first[0].equals(second[0]) || first[0].equals(second[1]) || 
				first[1].equals(second[0]) || first[1].equals(second[1]);
	}
	
//	for (int i = 0; i < couples.size(); i++) {
//		for (int j = 0; j < couples.size(); j++) {
//				String first = couples.get(i);
//				String second = couples.get(j);
//				if(extractString(first).equals(extractString(second))){
//					if (!equalCouples(first, second)) {
//						System.out.println(first+"=="+second);
//						print = true;
//					}
//				}
//		}
//	}
}
