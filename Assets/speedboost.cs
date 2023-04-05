using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedboost : MonoBehaviour
{
    public float speedMultiplier = 3f; // Multiplicateur de vitesse
    public float boostDuration = 10f; // Durée du boost en secondes

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController playerController = other.GetComponent<FirstPersonController>();
            if (playerController != null)
            {
                playerController.MoveSpeed *= speedMultiplier; // Multiplier la vitesse du joueur
                Invoke("ResetSpeed", boostDuration); // Rétablir la vitesse normale du joueur après la durée du boost
            }

            gameObject.SetActive(false); // Désactiver l'objet "speed boost"
        }
    }

    private void ResetSpeed()
    {
        FirstPersonController playerController = FindObjectOfType<FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed /= speedMultiplier; // Rétablir la vitesse normale du joueur
        }
    }
}
