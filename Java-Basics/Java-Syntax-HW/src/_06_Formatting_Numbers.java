import java.util.Scanner;

public class _06_Formatting_Numbers {
	
	public static String getHex(int num){
		String result = "";
		while(num > 0){
			int rest = num % 16;
			num = num / 16;
			char add = '#';
			switch(rest){
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9: add = (char)(rest + '0'); break;
				case 10: add = 'A'; break;
				case 11: add = 'B'; break;
				case 12: add = 'C'; break;
				case 13: add = 'D'; break;
				case 14: add = 'E'; break;
				case 15: add = 'F'; break;
			}
			
			result += add;
		}
		
		return new StringBuilder(result).reverse().toString();
	}
	
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Input a");
		Integer a = scan.nextInt();
		System.out.println("Input b");
		Double b = scan.nextDouble();
		System.out.println("Input c");
		Double c = scan.nextDouble();
		
		System.out.format("|%-10s", getHex(a));
		System.out.format("|%010d", Integer.parseInt(Integer.toBinaryString(a)));
		System.out.format("|%10.2f", b);
		System.out.format("|%-10.3f|", c);
	}
}
