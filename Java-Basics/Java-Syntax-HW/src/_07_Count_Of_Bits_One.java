import java.util.Scanner;


public class _07_Count_Of_Bits_One {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Insert number : ");
		Integer num = scan.nextInt();
		String bitStr = Integer.toBinaryString(num);
		int count = 0;
		
		for (int i = 0; i < bitStr.length(); i++) {
			if(bitStr.charAt(i) == '1'){ count++; }
		}
		
		System.out.println("There are " + count + " bits with value 1!");
	}
}
