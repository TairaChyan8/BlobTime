using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogData : MonoBehaviour
{
    [SerializeField] private string DialogName;
    [SerializeField] private List<DialogStage> _dialogStages;

    public bool GetDialogStage(int Position, out DialogStage dialogStage)
    {
        dialogStage = _dialogStages.Find(stage => stage.Position == Position);
        if (dialogStage == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
[System.Serializable]
public class DialogStage
{
    public int Position;
    public string DialogText;
    public string CharecterName;
    public Sprite CharacterIcon;
}