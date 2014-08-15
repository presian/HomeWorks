import java.util.Scanner;

import javax.swing.text.html.parser.Parser;



public class SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int start = in.nextInt();
		int end = in.nextInt();
		for (int i = start; i <= end; i++) {
			if ((i>=0)&&(i<=9)) {
				System.out.println(i);
			}
			else {
				String num = Integer.toString(i);
				char[] numbers = num.toCharArray();
				int[] number = new int[numbers.length];
				for (int j = 0; j < numbers.length; j++) {
					number[j] = Character.getNumericValue(numbers[j]);
				}
				for (int k = 0, r=number.length-1; k < number.length/2; k++, r--) {
					if (number[k] == number[r]) {
						System.out.println(i);
					}
				}
			}
			
		}
	}

}
