import java.util.Scanner;


public class AngleUnitConverter {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int count = in.nextInt();
		String[] angle = new String[count*2];
		String unit = "deg";
		for (int i = 0; i < count*2; i++) {
			angle[i] = in.next();
		}
		for (int j = 0; j < angle.length; j++) {
			if ((j==1)||((j>1)&&(j%2==1))) {
				double result = convertor(angle [j-1], angle[j]);
				if (angle[j].equals(unit)) {
					System.out.printf("%1$.6f rad \n", result);
				}
				else {
					System.out.printf("%1$.6f deg \n", result);
				}
			}
		}
	}
	public static double convertor(String a, String b){
		double value = Double.valueOf(a);
		double result = 0;
		switch (b) {
		case "deg": result = value * (Math.PI/180);
			break;
		case "rad": result = value  * (180/Math.PI);
			break;
		default:
			break;
		}
		return result;
	}
	
}

