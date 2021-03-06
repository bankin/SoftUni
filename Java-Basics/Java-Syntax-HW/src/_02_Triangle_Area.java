import java.util.Scanner;


public class _02_Triangle_Area {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Integer triangle[][] = new Integer[3][2];
		for (int i = 0; i < 3; i++) {
			System.out.println("Insert the coordinates of point " + (i+1) + " : ");
			String[] splited = scan.nextLine().split(" ");
			triangle[i][0] = Integer.parseInt(splited[0]);
			triangle[i][1] = Integer.parseInt(splited[1]);
		}
		
		Integer size = triangle[0][0]*(triangle[1][1] - triangle[2][1]);
		size += triangle[1][0]*(triangle[2][1] - triangle[0][1]);
		size += triangle[2][0]*(triangle[0][1] - triangle[1][1]);
		size = Math.abs(size);
		
		System.out.println("The are of the triangle is " + Math.round(size/2.0));
	}
}
