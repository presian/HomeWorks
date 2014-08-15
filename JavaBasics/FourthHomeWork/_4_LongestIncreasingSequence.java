import java.util.Scanner;


public class _4_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] digit = input.split(" ");
		int[] num = new int[digit.length];
		int counter = 1;
		int maxCounter = 0;
		int indexLastNumOfMax = 0;
		for (int i = 0; i < digit.length; i++) {
			num[i] = Integer.parseInt(digit[i]);
		}
		System.out.print(num[0]);
		for (int j = 0; j < num.length; j++) {
			if ((num.length>1)&&(j>0)) {
				if (num[j]>num[j-1]) {
					counter++;
					System.out.print(" " + num[j]);
					if (counter>maxCounter) {
						maxCounter=counter;
						indexLastNumOfMax = j;
					}
				}
				else {
					System.out.println();
					System.out.print(num[j]);
					counter=1;
				}
			}
		}
		System.out.println();
		System.out.print("Longest: ");
		for (int k = indexLastNumOfMax - (maxCounter - 1); k <= indexLastNumOfMax; k++) {
			System.out.print(num[k] + " ");
		}
	}

}
