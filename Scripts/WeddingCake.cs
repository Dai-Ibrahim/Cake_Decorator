using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeddingCake : MonoBehaviour, ICake
{
    private Color _color;
    public void Spawn()
    {
        GameObject spawn = Instantiate(Resources.Load<GameObject>("WeddingCake"));
        //spawn.transform.localScale *= _scale;
		spawn.GetComponent<Renderer> ().material.color = _color;
    }

    public WeddingCake(byte r, byte g, byte b)
    {
       // _scale = scale;
		_color = new Color32(r, g, b, 255);
    }
}
