import java.util.Scanner;


public class _5_CountAllWords {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] words = input.split("\\W+");
		System.out.print(words.length);
	}

}
