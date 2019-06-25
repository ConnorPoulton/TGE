using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public Room currentRoom;
    private static RoomManager _instance; 

    void Awake()
    {
        _instance = this;
    }

    public void LoadRoom()
    {

    }

    public void ChangeRoom(Room newRoom)
    {

    }
}
