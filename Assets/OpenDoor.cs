using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject doorObject;

    private void OnTriggerStay(Collider other)
    {
        doorObject.SetActive(false);
        
    }
    void OnTriggerExit(Collider other)
    {
        doorObject.SetActive(true);
    }
}