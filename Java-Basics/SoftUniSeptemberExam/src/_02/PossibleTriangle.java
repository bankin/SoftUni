package _02;

import java.util.Arrays;
import java.util.Scanner;

public class PossibleTriangle {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Boolean print = false;
		String line = scan.nextLine();
		
		while(!line.equals("End")){
			String[] sides = line.split(" ");
			double[] triangle = new double[3];
			triangle[0] = Double.parseDouble(sides[0]);
			triangle[1] = Double.parseDouble(sides[1]);
			triangle[2] = Double.parseDouble(sides[2]);
			
			Arrays.sort(triangle);
			
			if(triangle[0] + triangle[1] > triangle[2]){
				System.out.format("%.2f+%.2f>%.2f\n",triangle[0],triangle[1],triangle[2]);
				print = true;
			}
			line = scan.nextLine();
		}
		
		if(!print){
			System.out.println("No");
		}
	}
}
