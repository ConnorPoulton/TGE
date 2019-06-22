using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICommand : ScriptableObject
{
    public abstract void Action(GameObject gameObject);
}
