import java.util.Scanner;
import java.util.regex.*;

public class _8_ExtractEmails {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine().toLowerCase();
		Pattern emailPattern = Pattern.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}"); 
		Matcher match = emailPattern.matcher(input);
		while (match.find()) {
			System.out.println(match.group());
			
		}
	}


}
