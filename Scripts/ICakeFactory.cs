using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICakeFactory
{
    ICake Create(CakeRequirements requirements);
}
