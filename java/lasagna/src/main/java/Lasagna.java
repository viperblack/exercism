public class Lasagna {
    /**
     * @return
     */
    public int expectedMinutesInOven(){
        return 40;
    }

    /**
     * @param remaining_time
     * @return
     */
    public int remainingMinutesInOven(int remaining_time){
        return expectedMinutesInOven() - remaining_time;
    }

    /**
     * @param layers
     * @return
     */
    public int preparationTimeInMinutes(int layers){
        return layers * 2;
    }

    /**
     * @param layers
     * @param oven_time
     * @return
     */
    public int totalTimeInMinutes(int layers, int oven_time){
        return preparationTimeInMinutes(layers) + oven_time;
    }
}
