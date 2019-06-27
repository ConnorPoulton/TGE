using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "commands/Over write text")]
public class OverWriteRoomText : ICommand {

    [TextArea]
    public string overwriteText;

    public override void Action()
    {
        RoomManager.instance.OverwriteCurrentRoomDescription(overwriteText);
    }
}
