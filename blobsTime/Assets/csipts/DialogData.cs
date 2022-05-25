using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SimpleDialog", menuName = "Dialogs/CreateSimpleDialog", order = 1)]
public class DialogData : ScriptableObject
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