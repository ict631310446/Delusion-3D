using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    public GameObject npcDialog_1;

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("K");
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShowDialog();
        }
    }


    /*public void ShowDialog()
    {
        if (Input.GetKey(KeyCode.E))
        {
            npcDialog_1.SetActive(true);
        }
        else
        {
            npcDialog_1.SetActive(false);
        }
    }*/


    public void ShowDialog()
    {
        npcDialog_1.SetActive(!npcDialog_1.activeSelf);
    }

    private void OnTriggerExit(Collider other)
    {
        npcDialog_1.SetActive(false);
    }
}
