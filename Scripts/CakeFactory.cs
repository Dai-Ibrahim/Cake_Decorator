using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeFactory : AbstractCakeFactory
{
    private readonly ICakeFactory _factory;
    private readonly CakeRequirements _requirements;

    public CakeFactory(CakeRequirements requirements)
    {
        switch (requirements.type)
        {
            case CakeType.WeddingCake:
                _factory = new WeddingCakeFactory();
                break;
            case CakeType.BirthdayCake:
                _factory = new BirthdayCakeFactory();
                break;
        }
        _requirements = requirements;
    }

    public override ICake Create()
    {
        return _factory.Create(_requirements);
    }
}
