package _02;

import java.util.Scanner;

public class MirrorNumbers {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Boolean print = false;
		int number = Integer.parseInt(scan.nextLine());
		String line = scan.nextLine();
		String[] numbers = line.split(" ");
		
		for (int i = 0; i < number; i++) {
			for (int j = i; j < number; j++) {
				if(i != j){
					String rev = new StringBuilder(numbers[j]).reverse().toString();
					if(numbers[i].equals(rev)){
						System.out.println(numbers[i] + "<!>"+numbers[j]);
						print = true;
					}
				}
			}
		}
		
		if(!print){
			System.out.println("No");
		}
	}
}
