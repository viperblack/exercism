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
        var ranking = new ArrayList<ProductionRemoteControlCar>();
        ranking.add(prc1);
        ranking.add(prc2);
        Collections.sort(ranking);
        return ranking;
    }
    
}
