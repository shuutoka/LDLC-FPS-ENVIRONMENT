using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    
    public void OnTriggerEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
        FindObjectOfType<PlayerTP>().SetCheckpointPosition(transform.GetChild(0).position);
        }
    }
}
