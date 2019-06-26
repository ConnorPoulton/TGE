using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerOption {

    public ICommand command;
    [TextArea]
    public string description;
}
