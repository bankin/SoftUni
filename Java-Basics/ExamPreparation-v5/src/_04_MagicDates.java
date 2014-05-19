import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class _04_MagicDates {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int startYear = scan.nextInt();
		int endYear = scan.nextInt();
		int magicWeight = scan.nextInt();
		
		Calendar calendar = Calendar.getInstance();
		calendar.clear();	
		calendar.set(Calendar.YEAR, startYear);
		Date date1 = calendar.getTime();
		
		System.out.println(date1);
		
		calendar.add(Calendar.DAY_OF_YEAR, 1);
		
		date1 = calendar.getTime();
		int month = calendar.get(Calendar.MONTH);
		int day = calendar.get(Calendar.DAY_OF_YEAR);
		int year = calendar.get(Calendar.YEAR);
		
		calendar.set(endYear, 0, 1);
		
		Date date2 = calendar.getTime();
		
		System.out.println(day);
		System.out.println(month);
		System.out.println(year);
		
		System.out.println(getMagicWeight("17032007"));
		
		final long DAY_IN_MILLIS = 1000 * 60 * 60 * 24;

		date1 = new Date(date1.getTime() + 42 * DAY_IN_MILLIS);
		
		System.out.println(date1);
		
		int diffInDays = (int) ((date1.getTime() - date2.getTime())/ DAY_IN_MILLIS );
		System.out.println(diffInDays);
		
		Calendar startCalendar = Calendar.getInstance();
		startCalendar.set(startYear, 0, 1, 0, 0);
		Calendar endCalendar = Calendar.getInstance();
		endCalendar.set(endYear, 0, 1, 0, 0);
		for (; !startCalendar.equals(endCalendar) ; startCalendar.add(Calendar.DATE, 1)) {			
			if(getMagicWeight(makeDate(startCalendar, "")) == magicWeight){
				System.out.println(makeDate(startCalendar, "-"));
			}
		}
	}

	public static String makeDate(Calendar cal, String separator){
		String date = "";
		date += cal.get(Calendar.DAY_OF_YEAR) < 10 ? "0" + cal.get(Calendar.DAY_OF_YEAR) : cal.get(Calendar.DAY_OF_YEAR);
		date += separator;
		date += cal.get(Calendar.MONTH) < 9 ? "0" + (cal.get(Calendar.MONTH) + 1) : cal.get(Calendar.MONTH) + 1;
		date += separator;
		date += cal.get(Calendar.YEAR);

		return date;
	}
	
	public static long getMagicWeight(String dateString) {
		System.out.println("Calculate for " + dateString);
		long magicWeight = 0;
		for (int i = 0; i < dateString.length(); i++) {
			for (int j = i+1; j < dateString.length(); j++) {
				magicWeight += Integer.parseInt(Character.toString(dateString.charAt(i))) * Integer.parseInt(""+dateString.charAt(j));
			}
		}
		
		return magicWeight;
	}
}
