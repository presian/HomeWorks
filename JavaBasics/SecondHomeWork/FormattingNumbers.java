import java.util.Locale;
import java.util.Scanner;


public class FormattingNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scan = new Scanner(System.in);
		int a = scan.nextInt();
		float b = scan.nextFloat();
		float c = scan.nextFloat();
		String d = String.format("%10s",Integer.toBinaryString(a)).replace(' ', '0');
		System.out.printf("|%1$-10X|%2$10s|%3$10.2f|%4$-10.3f|", a, d, b, c);
		
	}

}
