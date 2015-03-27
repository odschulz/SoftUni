import java.time.*;
import java.util.*;

public class _05CurrentDateTime {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);

		System.out.printf("%1$tb %1$td, %1$tY, %1$tH:%1$tM", LocalDateTime.now());
	}

}
