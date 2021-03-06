import java.util.Scanner;


public class _05_Angle_Unit_Converter {
	public static double degToRad(double deg){
		return deg*Math.PI/180.0;
	}
	
	public static double radToDeg(double rad){
		return rad*180.0/Math.PI;
	}
	
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Input number of data lines : ");
		int count = scan.nextInt();
		scan.nextLine();
		for (int i = 0; i < count; i++) {
			String[] currLine = scan.nextLine().split(" ");
			if(currLine[1].equals("deg")){
				System.out.println(degToRad(Double.parseDouble(currLine[0])) + " rad");
			}
			else{
				System.out.println(radToDeg(Double.parseDouble(currLine[0])) + " deg");
			}			
		}				
	}
}
