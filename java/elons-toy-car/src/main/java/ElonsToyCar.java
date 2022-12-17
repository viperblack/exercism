public class ElonsToyCar {
    private int distance = 0;
    private int battery = 100;

    /**
     * @return
     */
    public static ElonsToyCar buy() {
        ElonsToyCar newCar = new ElonsToyCar();
        return newCar;
    }

    /**
     * @return
     */
    public String distanceDisplay() {
        return "Driven " + distance + " meters";
    }

    /**
     * @return
     */
    public String batteryDisplay() {
        if (battery > 0) {
            return "Battery at " + battery + "%";
        }

        return "Battery empty";
    }

    public void drive() {
        if (battery > 0) {
            distance = distance + 20;
            battery = battery - 1;
        }
    }
}
