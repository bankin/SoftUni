import java.util.Arrays;
import java.util.Scanner;

public class _08_Sort_Array_Of_Strings {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Insert the number of the names : ");
		Integer count = scan.nextInt();
		System.out.println("Insert " + count + " names ");
		String names[] = new String[count];
		for (int i = 0; i < count; i++) {
			names[i] = scan.nextLine();
		}
		Arrays.sort(names);
		
		for (int i = 0; i < count; i++) {
			System.out.println(names[i]);
		}
	}
}
