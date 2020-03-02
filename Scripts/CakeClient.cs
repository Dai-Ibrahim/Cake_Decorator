using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeClient : MonoBehaviour
{
    public Dropdown cakeTypeDropdown;
    public Dropdown cakeFrostingDropdown;
    public Dropdown cakeDecorationDropdown;

    [Header("Default values to what the sliders are")]
    public CakeType type = CakeType.BirthdayCake;
    public CakeFrosting frosting = CakeFrosting.Chocolate;
    public CakeDecor decor = CakeDecor.Topper;

    private CakeRequirements clientRequirements;
    private ICake newCake;

    private void Start()
    {
        clientRequirements = new CakeRequirements();
        clientRequirements.type = type;
        clientRequirements.frosting = frosting;
        clientRequirements.decor = decor;
    }
	private void Update()
	{
		SetType();
		SetDecoration();
		SetFrosting();
	}
	

    private ICake GetCake(CakeRequirements requirements)
    {
        CakeFactory factory = new CakeFactory(requirements);
		Debug.Log(requirements.decor);
        switch (requirements.decor)
        {
            case CakeDecor.None:
                newCake = factory.Create();
                newCake.Spawn();
                return newCake;
            case CakeDecor.Sprinkles:
                newCake = new SprinkleDecoration(factory.Create());
                return newCake;
            case CakeDecor.Topper:
                newCake = new TopperDecoration(factory.Create());
                return newCake;
            default:
                newCake = factory.Create();
                newCake.Spawn();
                return newCake;
        }
    }

    public void Create()
    {
        newCake = GetCake(clientRequirements);
        //newItem.Spawn();
    }

    public void SetType()
    {
		Debug.Log("SettingType");

        switch (cakeTypeDropdown.value)
        {
            case 0:
                clientRequirements.type = CakeType.WeddingCake;
                break;
            case 1:
                clientRequirements.type = CakeType.BirthdayCake;
                break;
        }

    }

    public void SetFrosting()
    {
        switch (cakeFrostingDropdown.value)
        {
            case 0:
                clientRequirements.frosting = CakeFrosting.Strawberry;
                break;
            case 1:
                clientRequirements.frosting = CakeFrosting.Vanilla;
                break;
            case 2:
                clientRequirements.frosting = CakeFrosting.Chocolate;
                break;
        }

    }

    public void SetDecoration()
    {
        switch (cakeDecorationDropdown.value)
        {
            case 0:
                clientRequirements.decor = CakeDecor.None;
                break;
            case 1:
                clientRequirements.decor = CakeDecor.Sprinkles;
                break;
            case 2:
                clientRequirements.decor = CakeDecor.Topper;
                break;
        }
    }

    public void DestroyAll()
    {
        GameObject[] allCharacters = GameObject.FindGameObjectsWithTag("Cake");
        for (int i = 0; i < allCharacters.Length; i++)
            Destroy(allCharacters[i]);
    }
}
