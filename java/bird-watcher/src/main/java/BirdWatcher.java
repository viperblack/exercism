
class BirdWatcher {
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        return birdsPerDay; 
    }

    public int getToday() {
        if (birdsPerDay.length == 0){
            return 0;
        }
        return birdsPerDay[6];
    }

    public void incrementTodaysCount() {
        birdsPerDay[6] = birdsPerDay[6] + 1;
    }

    public boolean hasDayWithoutBirds() {
        for (int birdsPerDay:birdsPerDay) {
            if (birdsPerDay == 0){
                return true;
            }
        }
        return false;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int sum = 0;
        if (numberOfDays <= birdsPerDay.length){
           for (int index = 0; index < numberOfDays; ++index) {
            sum += birdsPerDay[index];
        }
        return sum;
        }
        return getCountForFirstDays(7);
        
    }

    public int getBusyDays() {
        int count = 0;
        for (int birdsPerDay:birdsPerDay) {
            if (birdsPerDay >= 5){
                count++;
            }
        }
        return count;
    }
}
