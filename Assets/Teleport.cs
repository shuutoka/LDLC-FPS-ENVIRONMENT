using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public Transform Arrivee;
    public GameObject PlayerCapsule;

    void OnTriggerStay(Collider other)
    {
        PlayerCapsule.transform.position = Arrivee.transform.position;
    }
}
