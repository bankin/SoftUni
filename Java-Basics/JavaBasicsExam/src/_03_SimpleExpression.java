import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.Scanner;

//   5   -  33  + 12 - 55 - 1   -  2  + 6
public class _03_SimpleExpression {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();		
		
		input = input.replaceAll("\\s+","");
		BigDecimal sum = BigDecimal.ZERO;
		//double sum = 0;
		boolean first = true;
		char sign = 'a';
		for (int i = 0; i < input.length(); i++) {
			String currNum = "";
			while(input.charAt(i) != '-' && input.charAt(i) != '+' && i < input.length() - 1){
				currNum += input.charAt(i);
				i++;
			}
			//System.out.println("currSign "+ sign);
			//System.out.println("currNum "+currNum);
			if(i < input.length() - 1){
				if (first) {
					sum = new BigDecimal(currNum);
					//sum = Double.parseDouble(currNum);
					first = false;
				}
				else{
					//double num = Double.parseDouble(currNum);
					BigDecimal num = new BigDecimal(currNum);
					if (sign == '-') {
						sum = sum.subtract(num);
						//sum -= num;
					}
					else{
						//System.out.println("Add");
						sum = sum.add(num);
						//sum += num;
					}
				}
			}
			else{
				currNum += input.charAt(input.length() - 1);
				BigDecimal num = new BigDecimal(currNum);
				//double num = Double.parseDouble(currNum);
				//System.out.println("Last num " + num);
				
				if (sign == '-') {
					sum = sum.subtract(num);
					//sum -= num;
				}
				else{
					//System.out.println("Add");
					sum = sum.add(num);
					//sum += num;
				}
			}
			sign = input.charAt(i);
		}
		
		DecimalFormat df = new DecimalFormat("#.#######");
		//System.out.printf("#.#######",sum);
		System.out.println(df.format(sum));
	}
}
