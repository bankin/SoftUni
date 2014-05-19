package LiveExamPreparation;

import java.util.Scanner;

public class _01_Trigle {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		boolean isTriangle = true;
		
		int xA = scan.nextInt();
		int yA = scan.nextInt();
		int xB = scan.nextInt();
		int yB = scan.nextInt();
		int xC = scan.nextInt();
		int yC = scan.nextInt();
		
		
		double distAB = getDistance(xA, yA, xB, yB);
		double distAC = getDistance(xA, yA, xC, yC);
		double distBC = getDistance(xB, yB, xC, yC);
		
		if(distAB + distBC <= distAC){ isTriangle = false; }
		if(distBC + distAC <= distAB){ isTriangle = false; }
		if(distAC + distAB <= distBC){ isTriangle = false; }
		
		if (!isTriangle) {
			System.out.println("No"); 
			System.out.printf("%.2f",distAB);
		}
		else{
			System.out.println("Yes");
			System.out.printf("%.2f",getTriangleArea(distAB, distAC, distBC));
		}
		
	}

	public static double getTriangleArea(double distAB, double distAC,
			double distBC) {
		double p = (distAB + distBC + distAC ) / 2;
		double result = p* (p - distAB)*(p - distBC)*(p - distAC);
		
		
		return Math.sqrt(result);
	}

	public static double getDistance(int xA, int yA, int xB, int yB) {
		
		double result = Math.pow(xB - xA, 2) + Math.pow(yB - yA, 2);
		return Math.sqrt(result);	
	}
}
