using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeddingCakeFactory : ICakeFactory
{
    public ICake Create(CakeRequirements requirements)
    {
        switch (requirements.frosting)
        {
            case CakeFrosting.Strawberry:
                return new WeddingCake(255, 105, 180);
            case CakeFrosting.Vanilla:
                return new WeddingCake(255,239,213);
            case CakeFrosting.Chocolate:
                return new WeddingCake(139,69,19);
            default:
                return new WeddingCake(255,239,213);
        }
    }
}