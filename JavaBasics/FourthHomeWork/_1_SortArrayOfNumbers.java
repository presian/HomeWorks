import java.util.Arrays;
import java.util.Scanner;


public class _1_SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		int[] digits = new int[n];
		for (int i = 0; i < digits.length; i++) {
			digits[i] = sc.nextInt(); 
		}
		Arrays.sort(digits);
		for (int j = 0; j < digits.length; j++) {
			System.out.print(digits[j] + " ");
		}

	}

}
