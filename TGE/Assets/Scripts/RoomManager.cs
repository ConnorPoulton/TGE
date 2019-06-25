using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{
    [SerializeField]
    private Room _currentRoom;
    public static RoomManager instance;
    [SerializeField]
    private Text _roomDescription;
    public Canvas ButtonCanvas;

    void Awake()
    {
        instance = this;
        LoadRoom();
    }

    public void LoadRoom()
    {
        _roomDescription.text = _currentRoom.description;
    }

    public void ChangeRoom(Room newRoom)
    {
        _currentRoom = newRoom;
        LoadRoom();
    }
}
