package LiveExamPreparation;

import java.util.Scanner;

public class _03_House {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);		
		int rows = scan.nextInt();
		
		printChar('.', rows/2);
		printChar('*', 1);
		printChar('.', rows/2);
		System.out.println();
		for (int i = 1; i < rows/2; i++) {
			printChar('.', rows/2 - i);
			printChar('*', 1);
			printChar('.', 2*i - 1);
			printChar('*', 1);
			printChar('.', rows/2 - i);
			System.out.println();
		}
		printChar('*', rows);
		System.out.println();
		for (int i = 0; i < rows/2 - 1; i++) {
			printChar('.', rows/4);
			printChar('*', 1);
			printChar('.', rows - (rows/4 + rows/4 + 2));
			printChar('*', 1);
			printChar('.', rows/4);
			System.out.println();
		}
		printChar('.', rows/4);
		printChar('*', rows - (rows/4 + rows/4));
		printChar('.', rows/4);
		
	}
	
	public static void printChar(char c, int i) {
		for (int j = 0; j < i; j++) {
			System.out.print(c);
		}		
	}
}
