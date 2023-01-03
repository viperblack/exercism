import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class TestTrack {

    public static void race(RemoteControlCar car) {
        car.drive();
        car.getDistanceTravelled();
    }

    public static List<ProductionRemoteControlCar> getRankedCars(ProductionRemoteControlCar prc1,
                                                                 ProductionRemoteControlCar prc2) {
        List<ProductionRemoteControlCar> ranking = new ArrayList<>();
        ranking.add(prc2);
        ranking.add(prc1);
        Collections.sort(ranking);
        return ranking;
    }
    
}
