import java.util.Scanner;


public class _01_Rectangle_Area {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Insert the rectangle sides separated by single space : ");
		String line = scan.nextLine();
		String[] splited = line.split(" ");
		
		Integer a = Integer.parseInt(splited[0]);
		Integer b = Integer.parseInt(splited[1]);
		
		System.out.println("The area of the rectangle is " + (a*b));
	}
}
