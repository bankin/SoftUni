package _02;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ValidUsernames {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String user1 = "";
		String user2 = "";
		String line = scan.nextLine();
		int maxLength = 0;
		
		ArrayList<String> allMatches = new ArrayList<String>();
		Matcher m = Pattern.compile("(\\b[A-Za-z]\\w+)").matcher(line);
		while (m.find()) {
			allMatches.add(m.group());
		}
		
		for (int i = 0; i < allMatches.size() - 1; i++) {
			if(allMatches.get(i).length() > 3 && allMatches.get(i).length() < 25){
				if(allMatches.get(i+1).length() > 3 && allMatches.get(i+1).length() < 25){
					int cLength = allMatches.get(i).length() + allMatches.get(i+1).length();
					
					if(cLength > maxLength){
						maxLength = cLength;
						user1 = allMatches.get(i);
						user2 = allMatches.get(i+1);
					}
				}
			}
			
		}
		
		System.out.println(user1);
		System.out.println(user2);
	}
}
