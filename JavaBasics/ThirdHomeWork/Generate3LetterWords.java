import java.util.Scanner;

public class Generate3LetterWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.next();
		char[] symbols = input.toCharArray();
		for (int i = 0; i < symbols.length; i++) {
			for (int j = 0; j < symbols.length; j++) {
				for (int k = 0; k < symbols.length; k++) {
					System.out.printf("%1$c%2$c%3$c ", symbols[i], symbols[j], symbols[k]);
				}
			}
		}
	}
}
