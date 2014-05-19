import java.util.Scanner;

public class _02_Pairs {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();
		String[] numbers = input.split(" ");
		boolean first = true;
		int maxPair = 0, minPair = 0;
		
		for (int i = 0; i < numbers.length - 1; i+=2) {
			int currentPair = Integer.parseInt(numbers[i]) + Integer.parseInt(numbers[i+1]);
			if (first) {
				minPair = currentPair;
				maxPair = currentPair;
				first = false;
			}
			else{
				if(currentPair < minPair){
					minPair = currentPair;
				}
				if(currentPair > maxPair){
					maxPair = currentPair;
				}
			}
		}
		
		if(maxPair == minPair){
			System.out.println("Yes, value=" + maxPair);
		}
		else{
			System.out.println("No, maxdiff=" + (maxPair - minPair));
		}
	}
}
