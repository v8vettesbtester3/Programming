package abc;

import java.time.*;

public class P01 {
	static long count;

	static void f(int LoLim, int HiLim, int size) {
		if (HiLim <= size) {
			for (int k = LoLim; k < HiLim; ++k) {
				f(k + 1, HiLim + 1, size);
			}
		} else {
			count++;
		}
		return;
	}

	public static void main(String[] args) {
		int boardSize = 18;
		int s = 2 * (boardSize - 1);
		int a = 0;
		int b = s - (s / 2 - 1);
		int nTrial = 1;
		double avgTime = 0.0;
		for (int t = 0; t < nTrial; t++) {

			count = 0;

			LocalDateTime now = LocalDateTime.now();
			long startTimeSec = now.getSecond();
			long startTimeNano = now.getNano();

			f(a, b, s);

			now = LocalDateTime.now();
			long endTimeSec = now.getSecond();
			long endTimeNano = now.getNano();

			System.out.println(count);

			// System.out.printf("%.4f ms", ((endTimeNano - startTimeNano) / 1000000.0));
			avgTime += (1000*(endTimeSec-startTimeSec)+(endTimeNano - startTimeNano) / 1000000.0);
		}

		avgTime /= nTrial;
		System.out.printf("%.4f ms", avgTime);

	}

}
