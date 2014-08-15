import java.util.Scanner;


public class _6_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] words = input.split("\\W+");
		String theWord = sc.next();
		int counter = 0;
		for (int i = 0; i < words.length; i++) {
			if (words[i].toLowerCase().equals(theWord.toLowerCase())) {
				counter++;
			}
		}
		System.out.print(counter);
		
	}

}
