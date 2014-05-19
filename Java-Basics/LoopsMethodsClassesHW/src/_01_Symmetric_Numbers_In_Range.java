import java.util.Scanner;


public class _01_Symmetric_Numbers_In_Range {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Input range : ");
		String[] line = scan.nextLine().split(" ");
		int a = Integer.parseInt(line[0]);
		int b = Integer.parseInt(line[1]);
		
		for (int i = a; i <= b; i++) {
			String currNum = Integer.toString(i);
			String reverse = new StringBuilder(currNum).reverse().toString();
			if(currNum.equals(reverse)){
				System.out.print(currNum + " ");
			}
		}
	}
}
