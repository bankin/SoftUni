import java.util.Scanner;


public class _05_Dec_To_Hex {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Integer num = scan.nextInt();
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
		
		System.out.println("Hex num = " + new StringBuilder(result).reverse());
	}
}
