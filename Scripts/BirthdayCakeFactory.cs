using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayCakeFactory : ICakeFactory
{
    public ICake Create(CakeRequirements requirements)
    {	Debug.Log(requirements.frosting);
        switch (requirements.frosting)
        {
            case CakeFrosting.Strawberry:
                return new BirthdayCake(255, 105, 180);
            case CakeFrosting.Vanilla:
                return new BirthdayCake(255,239,255);
            case CakeFrosting.Chocolate:
                return new BirthdayCake(139,69,19);
            default:
                return new BirthdayCake(255,0,213);
        }
    }
}