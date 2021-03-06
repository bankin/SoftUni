import java.util.Scanner;

public class _09_Points_Inside_House {
	public static Double[] p1 = {12.5, 8.5};
	public static Double[] p2 = {17.5, 3.5};
	public static Double[] p3 = {22.5, 8.5};
	
	public static Double sign(Double p1[], Double p2[], Double p3[])
	{
	  return (p1[0] - p3[0]) * (p2[1] - p3[1]) - (p2[0] - p3[0]) * (p1[1] - p3[1]);
	}

	public static Boolean PointInTrianlge(Double p[], Double p1[], Double p2[], Double p3[])
	{
	  boolean b1, b2, b3;

	  b1 = sign(p, p1, p2) < 0.0f;
	  b2 = sign(p, p2, p3) < 0.0f;
	  b3 = sign(p, p3, p1) < 0.0f;

	  return ((b1 == b2) && (b2 == b3));
	}
	
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("Insert point coordinates: ");
		String[] line = scan.nextLine().split(" ");
		Double point[] = new Double[2];
		point[0] = Double.parseDouble(line[0]);
		point[1] = Double.parseDouble(line[1]);
		
		if(point[0] < 12.5){ System.out.println("Outside"); return; }
		if(point[0] > 22.5){ System.out.println("Outside"); return; }
		if(point[1] < 3.50){ System.out.println("Outside"); return; }
		if(point[1] > 13.5){ System.out.println("Outside"); return; }
		if(point[1] > 8.5 && (point[0] > 17.5 && point[0] < 20)){ 
			System.out.println("Outside"); 
			return; 
		}
		if(point[1] <= 8.5){
			if(!PointInTrianlge(point, p1, p2, p3)){ 
				System.out.println("Outside"); 
				return; 
			}
		}
		
		System.out.println("Inside");
	}
}
