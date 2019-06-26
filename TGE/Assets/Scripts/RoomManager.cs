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
    public GameObject buttonPanel;
    public ButtonPool buttonPool;

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
            GameObject button = buttonPool.GetPooledObject();
            button.transform.SetParent(buttonPanel.transform);
            button.GetComponentInChildren<Text>().text = option.description;
            button.GetComponentInChildren<Button>().onClick.AddListener(option.command.Action);
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
}
