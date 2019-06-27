using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Room")]
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public List<PlayerOption> playerOptions = new List<PlayerOption>();	
}
