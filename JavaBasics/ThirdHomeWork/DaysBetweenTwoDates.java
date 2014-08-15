import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;


public class DaysBetweenTwoDates {

	public static void main(String[] args) throws ParseException {
		Scanner in = new Scanner(System.in);
		String first = in.next();
		String second = in.next();
		SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
		Date d1 = format.parse(first);
		Date d2 = format.parse(second);
		long dif = d2.getTime()-d1.getTime();
		long difDays = dif/(24 * 60 * 60 * 1000);
		
		System.out.print(difDays);
		}

}