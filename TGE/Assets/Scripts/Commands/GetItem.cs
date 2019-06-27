using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "commands/get item")]
public class GetItem : ICommand
 {
    [TextArea]
    public string itemGetDescription;
    public Item itemToAdd;


    public override void Action()
    {
        RoomManager.instance.AddToRoomDescription(itemGetDescription);
        InventoryManager.instance.AddItem(itemToAdd);
    }

}
