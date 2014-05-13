import java.util.Scanner;


public class _08_Count_Of_Equal_Bit_Pairs {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Insert number : ");
		Integer num = scan.nextInt();
		String bitStr = Integer.toBinaryString(num);
		int count = 0;
		
		for (int i = 0; i < bitStr.length() - 1; i++) {
			if(bitStr.charAt(i) == bitStr.charAt(i+1)){ count++; }
		}
		
		System.out.println("There are " + count + " bits pairs!");
	}
}
