using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CakeDecorator : MonoBehaviour, ICake
{
    public string decorationName;
    protected ICake newCake;

    public virtual void Spawn()
    {
		Debug.Log(decorationName);
        GameObject decorationSpawn = Instantiate(Resources.Load<GameObject>(decorationName));
        //return flagSpawn;
        newCake.Spawn();
    }
}

public class SprinkleDecoration : CakeDecorator
{
    private string sprinkleName = "Sprinkles";

    public SprinkleDecoration(ICake cake)
    {
        decorationName = sprinkleName;
        newCake = cake;
        base.Spawn();
    }
}

public class TopperDecoration : CakeDecorator
{
    private string topperName = "Topper";

    public TopperDecoration(ICake cake)
    {
        decorationName = topperName;
        newCake = cake;
        base.Spawn();
    }
}

