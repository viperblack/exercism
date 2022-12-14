public class CarsAssemble {

    public double productionRatePerHour(int speed) {
        final int CARS = 221;

        switch (speed) {
            case 1:
            case 2:
            case 3:
            case 4:
                return speed * CARS;
            case 5:
            case 6:
            case 7:
            case 8:
                return speed * CARS * 0.9;
            case 9:
                return speed * CARS * 0.8;
            case 10:
                return speed * CARS * 0.77;
            default:
                return 0;
        }
        }

    /**
     * @param speed
     * @return
     */
    public int workingItemsPerMinute(int speed) {
        return (int)productionRatePerHour(speed) / 60;
    }
}
