class ProductionRemoteControlCar implements RemoteControlCar, Comparable<ProductionRemoteControlCar> {

    private int distance = 0;
    private int totalofVictories = 0;

    public void drive() {
        distance += 10;
    }

    public int getDistanceTravelled() {
        return distance;
    }

    public int getNumberOfVictories() {
        return totalofVictories;
    }

    public void setNumberOfVictories(int numberofVictories) {
        totalofVictories += numberofVictories;
    }

    @Override
    public int compareTo(ProductionRemoteControlCar ranked) {
            return this.totalofVictories > ranked.totalofVictories ? 0 : 1;
    }
}
