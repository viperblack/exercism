import java.time.LocalDate;
import java.time.LocalDateTime;

public class Gigasecond {
    private LocalDateTime momentPass;
    private int GIGASECOND = 1_000_000_000;

    public Gigasecond(LocalDate moment) {
        momentPass = moment.atStartOfDay(); //atStartOfDay() method of LocalDate class in Java is combines this date with the time of midnight to create a LocalDateTime at the start of this date
    }

    public Gigasecond(LocalDateTime moment) {
       momentPass = moment; 
    }

    public LocalDateTime getDateTime() {
       return momentPass.plusSeconds(GIGASECOND);
    }
}
