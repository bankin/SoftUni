import java.text.SimpleDateFormat;
import java.util.Date;

public class _05_Current_DateTime {
	public static void main(String[] args) {		
		System.out.println(new SimpleDateFormat("yyyy-MM-dd HH:mm:SS").format(new Date()));
	}
}
