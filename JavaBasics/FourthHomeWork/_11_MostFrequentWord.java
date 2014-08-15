import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String[] input = sc.nextLine().toLowerCase().split("\\W+");
		Arrays.sort(input);
		Map<String, Integer> wordsCount = new HashMap<String, Integer>();
		for (String word : input) {
			Integer count = wordsCount.get(word);
			if (count == null) {
				count = 0;
			}
			wordsCount.put(word, count+1);
		}
		int highestCount = 0;                                                           //Find the highest count of a word
        for(String word : wordsCount.keySet()){
                int count = wordsCount.get(word);
                if(count > highestCount){
                        highestCount = count;
                }
        }
       
       
        for(String word : wordsCount.keySet()){                                     //Print the word/s with highest count
                int count = wordsCount.get(word);
                if(count == highestCount){
                        System.out.printf("%s -> %d times \n", word, count);
                }
        }
	}

}
