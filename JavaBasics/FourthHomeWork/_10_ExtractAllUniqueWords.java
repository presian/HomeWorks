
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		ArrayList<String> out = new ArrayList<>();
		Scanner sc = new Scanner(System.in);
		String[] input = sc.nextLine().toLowerCase().split("\\W+");
		Arrays.sort(input);
		for (int i = 0; i < input.length; i++) {
			if ((i>0)&&(input[i].equals(input[i-1]))) {
				continue;
			}
			else {
				out.add(input[i]);
				out.add(" ");
			}
		}
		for (int i = 0; i < out.size(); i++) {
			System.out.print(out.get(i));
		}
	}
	
}
