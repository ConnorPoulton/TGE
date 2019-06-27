using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "item")]
public class Item : ScriptableObject
{
    public string itemName;
    public string[] tags;
}
