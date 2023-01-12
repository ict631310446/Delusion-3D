using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class PickUpSystem : MonoBehaviour
{
    public GameObject UiPickUp;
    public GameObject itemModel;
    private GameObject modelPrefab;
    
    private bool isInspecting = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UiPickUp.SetActive(true);
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                UiPickUp.SetActive(false);
                PickUpitem();
            }
        }
    }

    private void PickUpitem()
    {
        itemModel.SetActive(true);
        Camera camera = Camera.main;
        Vector3 cameraForward = camera.transform.forward;
        itemModel.transform.position = camera.transform.position + (cameraForward * 2);
        isInspecting = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UiPickUp.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        itemModel = Instantiate(modelPrefab, transform.position, Quaternion.identity);
    }
    
    private void HandleInspectionInput() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            isInspecting = false;
            itemModel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleInspectionInput();
    }
}
