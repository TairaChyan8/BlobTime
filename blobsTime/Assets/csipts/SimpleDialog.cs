using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimpleDialog : MonoBehaviour
{
    [SerializeField] private Image _characterImage;
    [SerializeField] private TMP_Text _characterText;
    [SerializeField] private TMP_Text _dialogText;
    [SerializeField] private Button _nextStageButton;

    [SerializeField] private DialogData _temporaryData;

    private int position = -1;
    private void NextDialog()
    {
        position++;
        if (_temporaryData.GetDialogStage(position, out var dialog))
        {
            _characterImage.sprite = dialog.CharacterIcon;
            _characterText.text = dialog.CharecterName;
            _dialogText.text = dialog.DialogText;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        position = -1;
        _nextStageButton.onClick.AddListener(NextDialog);
        NextDialog();
    }
}

