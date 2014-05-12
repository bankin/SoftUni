import java.util.Scanner;

public class _06_Sum_Two_Numbers {
	public static void main(String[] args) {
		System.out.println("Insert two nubmbers: ");
	    Scanner scanner = new Scanner(System.in);
	    Integer firstNum = scanner.nextInt();
	    Integer secondNum = scanner.nextInt();
	    System.out.println("The sum is " + (firstNum + secondNum));
	}
}
