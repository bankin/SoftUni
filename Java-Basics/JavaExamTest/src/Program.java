import java.util.Scanner;


public class Program {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		double x = scan.nextDouble();
		double y = scan.nextDouble();
		
		if(x == 0 && y == 0){ System.out.println("0"); }
		else if(x == 0 && y != 0) { System.out.println("5"); }
		else if(x != 0 && y == 0) { System.out.println("6"); }
		else if(x > 0 && y > 0){ System.out.println("1"); }
		else if(x > 0 && y < 0){ System.out.println("4"); }
		else if(x < 0 && y > 0){ System.out.println("2"); }
		else if(x < 0 && y < 0){ System.out.println("3"); }
	}
}
