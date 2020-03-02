using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayCake : MonoBehaviour, ICake
{
    private Color _color;
    public void Spawn()
    {
        GameObject spawn = Instantiate(Resources.Load<GameObject>("BirthdayCake"));
        //spawn.transform.localScale *= _scale;
		spawn.GetComponent<Renderer> ().material.color = _color;
    }

    public BirthdayCake(byte r, byte g, byte b)
    {
       // _scale = scale;
	   Debug.Log("imhere");
		_color = new Color32(r, g, b, 255);
    }
}
