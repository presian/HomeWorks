import java.util.Scanner;


public class _7_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine().toLowerCase();
		String word = sc.next().toLowerCase();
		int counter = 0;
		for (int i = 0; i < input.length()-word.length(); i++) {
			if (input.substring(0+i, word.length()+i).contains(word)) {
				counter++;
			}
		}
		System.out.print(counter);
		
		}

}
