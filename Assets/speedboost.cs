using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedboost : MonoBehaviour
{
    public float speedMultiplier = 3f; // Multiplicateur de vitesse
    public float boostDuration = 10f; // Dur�e du boost en secondes

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController playerController = other.GetComponent<FirstPersonController>();
            if (playerController != null)
            {
                playerController.MoveSpeed *= speedMultiplier; // Multiplier la vitesse du joueur
                Invoke("ResetSpeed", boostDuration); // R�tablir la vitesse normale du joueur apr�s la dur�e du boost
            }

            gameObject.SetActive(false); // D�sactiver l'objet "speed boost"
        }
    }

    private void ResetSpeed()
    {
        FirstPersonController playerController = FindObjectOfType<FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed /= speedMultiplier; // R�tablir la vitesse normale du joueur
        }
    }
}
