using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (!knightIsAwake){
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake | !archerIsAwake | !prisonerIsAwake)
        {
            if (knightIsAwake & !archerIsAwake & prisonerIsAwake)
            {
                return true;
            }
            else if (knightIsAwake ^ archerIsAwake ^ prisonerIsAwake)
            {
                return true;
            }
            else if (knightIsAwake & archerIsAwake & !prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake & !archerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (!knightIsAwake | archerIsAwake | !prisonerIsAwake | !petDogIsPresent)
        {
            if (!knightIsAwake & !archerIsAwake & !prisonerIsAwake & !petDogIsPresent)
            {
                return false;
            }
            else
           if (!knightIsAwake & !archerIsAwake & prisonerIsAwake & petDogIsPresent)
            {
                return true;
            }
            else
           if (!knightIsAwake & !archerIsAwake & prisonerIsAwake & !petDogIsPresent)
            {
                return true;
            }
            else
           if (knightIsAwake & !archerIsAwake & !prisonerIsAwake & petDogIsPresent)
            {
                return true;
            }
            else
           if (!knightIsAwake & !archerIsAwake & !prisonerIsAwake & petDogIsPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
