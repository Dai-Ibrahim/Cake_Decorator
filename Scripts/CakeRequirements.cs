using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CakeType
{
    WeddingCake,
    BirthdayCake
}

public enum CakeFrosting
{
    Strawberry,
    Vanilla,
    Chocolate
}

public enum CakeDecor
{
    None,
    Sprinkles,
    Topper
}

public class CakeRequirements
{
    public CakeType type;
    public CakeFrosting frosting;
    public CakeDecor decor = CakeDecor.None;
}
