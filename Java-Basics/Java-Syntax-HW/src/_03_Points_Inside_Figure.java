import java.util.Scanner;


public class _03_Points_Inside_Figure {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Double point[] = new Double[2];
		String[] line = scan.nextLine().split(" ");
		point[0] = Double.parseDouble(line[0]);
		point[1] = Double.parseDouble(line[1]);
		scan.close();
		
		if(point[1] < 6.00) { System.out.println("Outside"); return; }
		if(point[1] > 13.5) { System.out.println("Outside"); return; }
		if(point[0] < 12.5) { System.out.println("Outside"); return; }
		if(point[0] > 22.5) { System.out.println("Outside"); return; }
		if((point[0] > 17.5 && point[0] < 20) && (point[1] > 8.5)) { System.out.println("Outside"); return; }
		
		System.out.println("Inside");
		
		
	}
}
