using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : ICommand {

    public Room currentRoom; 

    public  override void Action(GameObject target)
    {
        RoomManager.instance.ChangeRoom(currentRoom);
    }

}
