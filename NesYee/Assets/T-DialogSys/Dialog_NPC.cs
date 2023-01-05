using UnityEngine;

public class Dialog_NPC : MonoBehaviour
{
    [SerializeField]
    public GameObject npcDialog_1;
    public Ui_DialogBox dialogBox;
    public string _npcName;


    [TextArea(3, 10)]
    public string[] dialogOptions;
    private int currentOption = 0;

    private void Start()
    {
        // Set the NPC name to the name of the GameObject this script is attached to
        string npcName = _npcName;

        // Make sure the DialogBox component is set in the Inspector
        if (dialogBox != null)
        {
            dialogBox.SetNPCName(npcName);
            dialogBox.SetDialogText(dialogOptions[currentOption]);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if the E key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShowDialog();
            currentOption++;
            if (currentOption >= dialogOptions.Length)
            {
                currentOption = 0;
            }

            // Make sure the DialogBox component is set in the Inspector
            if (dialogBox != null)
            {
                dialogBox.SetDialogText(dialogOptions[currentOption]);
            }
        }
    }

    public void ShowDialog()
    {
        // Make sure the NPC dialog game object is set in the Inspector
        if (npcDialog_1 != null)
        {
            npcDialog_1.SetActive(!npcDialog_1.activeSelf);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Make sure the NPC dialog game object is set in the Inspector
        if (npcDialog_1 != null)
        {
            npcDialog_1.SetActive(false);
        }
    }
}
