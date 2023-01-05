using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ui_DialogBox : MonoBehaviour
{
    public TMP_Text npcNameField;
    public TMP_Text dialogTextField;

    public void SetNPCName(string name)
    {
        npcNameField.text = name;
    }

    public void SetDialogText(string text)
    {
        dialogTextField.text = text;
    }
}