using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            gameObject.SetActive(false); // D�sactiver l'objet "jump boost"
    }

}
