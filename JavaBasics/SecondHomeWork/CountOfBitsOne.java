import java.util.Scanner;


public class CountOfBitsOne {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int counter = 0;
		String num = Integer.toBinaryString(n);
		char[] number = num.toCharArray();
		for (int i = 0; i < num.length(); i++) {
			if (number[i]=='1') {
				counter++;
			}
			System.out.println(number[i]);
		}
		System.out.println(counter);
	}
}

