using System;

abstract class Character
{
    public string typeCharacter;
    protected Character(string characterType)
    {
        this.typeCharacter = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool GetVulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return "Character is a " + typeCharacter;
    }
}

class Warrior : Character
{
    public Warrior() : base(characterType: "Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.GetVulnerable())
        {
            return 10;
        }
        return 6;

    }
}

class Wizard : Character
{
    public bool spell = false;
    public Wizard() : base(characterType: "Wizard")
    {

    }

    public override int DamagePoints(Character target)
    {
        if (this.spell)
        {
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        this.spell = true;
    }

    public override bool GetVulnerable()
    {
        if (this.spell)
        {
            return base.GetVulnerable();
        }
        return true;
    }
}
