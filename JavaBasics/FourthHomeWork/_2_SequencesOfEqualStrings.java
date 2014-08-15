import java.util.Arrays;
import java.util.Scanner;


public class _2_SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] str = input.split(" ");
		System.out.print(str[0] + " ");
		for (int i = 1; i < str.length; i++) {
			if (str[i].equals(str[i-1])) {
				System.out.print(str[i] + " ");
			}
			else {
				System.out.println();
				System.out.print(str[i] + " ");
			}
		}

	}

}
