package LiveExamPreparation;

import java.util.Scanner;

public class _02_Pairs {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();
		int maxPairDiff = 0, lastPairSum = 0;
		
		String[] numbers = input.split(" ");
		
		for (int i = 0; i < numbers.length - 1; i+= 2) {
			int currentPairSum = Integer.parseInt(numbers[i]) + Integer.parseInt(numbers[i+1]);
			if(i != 0){
				if (i == 2) {
					maxPairDiff = Math.abs(currentPairSum - lastPairSum);
				}
				else{
					if(currentPairSum != lastPairSum){
						int diff = Math.abs(currentPairSum - lastPairSum);
						if (diff > maxPairDiff) {
							maxPairDiff = diff;
						}
					}
				}
			}
			lastPairSum = currentPairSum;
		}
		
		if (maxPairDiff == 0) {
			System.out.println("Yes, value="+lastPairSum);		
		}
		else{
			System.out.println("No, maxdiff="+maxPairDiff);
		}
	}
}
