import java.util.Locale;
import java.util.Scanner;


public class TheSmallestOfThreeNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		float num = scanner.nextFloat();
		float num1 = scanner.nextFloat();
		float num2 = scanner.nextFloat();
		float smallest = num;
		if (num1 < smallest) {
			smallest = num1;
		}
		if (num2 < smallest) {
			smallest = num2;
		}
		if ((smallest % (int)smallest) == 0) {
			System.out.println((int)smallest);
		}
		else {
			System.out.println(smallest);
		}
		
	}



}
