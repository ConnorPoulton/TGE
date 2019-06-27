using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public static InventoryManager instance;
    private List<Item> items = new List<Item>();

    void Awake()
    {
        instance = this;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }
}
