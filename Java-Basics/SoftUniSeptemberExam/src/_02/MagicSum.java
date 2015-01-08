package _02;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class MagicSum {
	public static void main(String[] args) {
		System.out.println("Console");
		Scanner scan = new Scanner(System.in);
		ArrayList<Integer> numbers = new ArrayList<Integer>();
		int d = Integer.parseInt(scan.nextLine());
		Boolean first = true;
		int max = 0;
		String maxString = "";
		String line = scan.nextLine();
		while(!line.equals("End")){
			numbers.add(Integer.parseInt(line));
			line = scan.nextLine();
		}
		
		for (int i = 0; i < Math.pow(2, numbers.size()); i++) {
			String bin = Integer.toBinaryString(i);
			bin = String.format("%"+ numbers.size() +"s", bin).replace(' ', '0');
			int countOnes = bin.split("1").length;
			if (countOnes == 3) {
				int currentSum = 0;
				String cSum = "";
				for (int j = 0; j < bin.length(); j++) {
					if(bin.charAt(j) == '1'){
						currentSum += numbers.get(j);
						cSum += numbers.get(j) + " + ";
					}
				}
				
				char[] word = cSum.toCharArray();
				
				
				
				if(first){
					if(currentSum % d == 0){
						max = currentSum;
						maxString = cSum;
						first = false;
					}
				}
				else{
					if(currentSum > max && currentSum % d == 0){
						max = currentSum;
						maxString = cSum;
					}
				}	
			}
		}
		
		if(first){
			System.out.println("No");
		}
		else{
			System.out.println("(");
		}
	}
}