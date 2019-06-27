using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerOption {

    public ICommand[] commands;
    [TextArea]
    public string description;
}
