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
    public ButtonPool buttonPool;
    public GameObject buttonPanel;
    private List<Room> roomInstances = new List<Room>();

    void Awake()
    {
        instance = this;
        LoadRoom();
    }

    public void LoadRoom()
    {
        _roomDescription.text = _currentRoom.description;
        foreach (PlayerOption option in _currentRoom.playerOptions)
        {
            Debug.Log("test");
            GameObject button = buttonPool.GetPooledObject();
            button.transform.SetParent(buttonPanel.transform);
            button.GetComponentInChildren<Text>().text = option.description;          
            for (int i = 0; i < option.commands.Length; i++)
            {
                button.GetComponentInChildren<Button>().onClick.AddListener(option.commands[i].Action);
            }
        }
    }

    public void ChangeRoom(Room newRoom)
    {
        _currentRoom = newRoom;
        foreach (Transform child in buttonPanel.transform)
        {
            buttonPool.ReturnToPool(child.gameObject);
        }
        LoadRoom();
    }

    public void AddToRoomDescription(string toAdd)
    {
        _roomDescription.text += (" " + toAdd);
    }

    public void OverwriteCurrentRoomDescription(string newDescription)
    {
        _currentRoom.description = newDescription;
        AddToRoomDescription(newDescription);
    }
}
