class AnnalynsInfiltration {
    /**
     * @param knightIsAwake
     * @return
     */
    public static boolean canFastAttack(boolean knightIsAwake) {
        return knightIsAwake ? false : true;
    }

    /**
     * @param knightIsAwake
     * @param archerIsAwake
     * @param prisonerIsAwake
     * @return
     */
    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) {
        return prisonerIsAwake | archerIsAwake | knightIsAwake ? true : false;
    }

    /**
     * @param archerIsAwake
     * @param prisonerIsAwake
     * @return
     */
    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake) {
        return !archerIsAwake & prisonerIsAwake ? true : false;
    }

    /**
     * @param knightIsAwake
     * @param archerIsAwake
     * @param prisonerIsAwake
     * @param petDogIsPresent
     * @return
     */
    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake, boolean petDogIsPresent) {
        return (!knightIsAwake & !archerIsAwake & prisonerIsAwake) | (!archerIsAwake & petDogIsPresent) ? true : false;
    }
}
