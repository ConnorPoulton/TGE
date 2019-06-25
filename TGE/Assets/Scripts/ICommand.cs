using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class ICommand : ScriptableObject
{
    public string description;
    public abstract void Action(GameObject gameObject);
}
