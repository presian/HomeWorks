import java.util.Scanner;


public class _3_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] array = input.split(" ");
		int counter = 1;
		int counterMax = 1;
		String maxString = array[0];
		for (int i = 0; i < array.length; i++) {
			if ((array.length == 2)&&(!(array[0].equals(array[1])))) {
				System.out.print(array[0]);
			}
			else if ((array.length >2)&&(i>0)) {
				if (array[i].equals(array[i-1])) {
					counter++;
					if (counter > counterMax) {
						counterMax=counter;
						maxString = array[i];
					}
				}
				else {
					
					counter=1;
				}
			}
		}
		for (int j = 0; j < counterMax; j++) {
			System.out.print(maxString + " ");
		}
	}

}
