using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public float teleportHeight = -1f; // Y value at which the player should be teleported
    public Transform initialPosition; // the initial position of the player

    void Update()
    {
        // check if the player's Y position is below the teleportHeight
        if (transform.position.y < teleportHeight)
        {
            // teleport the player to the initial position
            transform.position = initialPosition.position;
        }
    }
}
