import java.util.Scanner;


public class _04_Smallest_Of_Three {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("a = ");
		Double a = scan.nextDouble();
		System.out.println("b = ");
		Double b = scan.nextDouble();
		System.out.println("c = ");
		Double c = scan.nextDouble();
		Double smallest;
		
		if(a < b){
			if( a < c){
				smallest = a;
			}
			else{
				smallest = c;
			}
		}
		else{
			if(b < c){
				smallest = b;
			}
			else{
				smallest = c;
			}
		}
		
		System.out.println("The max is " + smallest);
	}
}
