using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
        FindObjectOfType<PlayerTP>().SetCheckpointPosition(transform.GetChild(0).position);
        FindObjectOfType<cubelave>().SavePosition();
        }
    }

    public void OnDrawGizmos()
    {
        var c = GetComponent<BoxCollider>();
        Color ca = Color.green;
        ca.a = 0.2f;
        Gizmos.color = ca;
        Gizmos.DrawCube(transform.position, c.size); 
         }
}
