import java.util.Scanner;


public class DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int num = scanner.nextInt();
		String hex = Integer.toHexString(num);
		System.out.printf("%S",hex);
	}

}
