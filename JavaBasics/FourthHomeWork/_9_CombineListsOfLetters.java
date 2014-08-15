
import java.util.ArrayList;
import java.util.Scanner;

import javax.swing.text.html.CSS;


public class _9_CombineListsOfLetters {

	public static void main(String[] args) {
		ArrayList<Character> l1 = new ArrayList<>();
		ArrayList<Character> l2 = new ArrayList<>();
		ArrayList<Character> out = new ArrayList<>();
		Scanner sc = new Scanner(System.in);
		for (char ch : sc.nextLine().toCharArray()) {
			l1.add(ch);
		}
		for (char ch : sc.nextLine().toCharArray()) {
			l2.add(ch);
		}
		out.addAll(l1);
		for (int i = 0; i < l2.size(); i++) {
			if (l1.contains(l2.get(i))) {
				continue;
			}
			else {
				out.add(' ');
				out.add(l2.get(i));
			}
		}
		for (int j = 0; j < out.size(); j++) {
			System.out.print(out.get(j));
		}
	}
}
