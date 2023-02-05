abstract class Fighter {

    boolean isVulnerable() {
        return false;
    }

    abstract int damagePoints(Fighter fighter);

    @Override
    public String toString() {
        return "Fighter is a " + getClass().getSimpleName();
    }
}

class Warrior extends Fighter {

    @Override
    int damagePoints(Fighter wizard) {
        return wizard.isVulnerable() ? 10 : 6;
    }
}

class Wizard extends Fighter {
    private boolean spellprepared = false;

    @Override
    boolean isVulnerable() {
        return !spellprepared;
    }

    @Override
    int damagePoints(Fighter warrior) {
        return isVulnerable() ? 3 : 12;
    }

    void prepareSpell() {
        spellprepared = true;
    }

}
