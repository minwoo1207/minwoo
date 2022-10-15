using UnityEngine;
using System;
using System.Collections;

public class ShieldClover : Consumable
{
    protected const int k_MaxLives = 1;
    protected const int k_CoinValue = 10;
    public override string GetConsumableName()
    {
        return "Clover";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.SHIELDCLOVER;
    }

    public override int GetPrice()
    {
        return 10;
    }

    public override int GetPremiumCost()
    {
        return 0;
    }

    public override bool CanBeUsed(CharacterInputController c)
    {
        if (c.shieldLife == true)
            return false;

        return true;
    }

    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        if (c.shieldLife == false)
            c.shieldLife = true;
        else
            c.coins += k_CoinValue;
    }

}
