import java.util.Locale;
import java.util.Scanner;


public class RectangleArea {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scan = new Scanner (System.in);
		double sideA = scan.nextDouble();
		double sideB = scan.nextDouble();
		System.out.println(sideA*sideB);
	}

}
