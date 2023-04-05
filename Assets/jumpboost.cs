using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpboost : MonoBehaviour
{
    public float jumpMultiplier = 2f; // Multiplicateur de saut
    public float boostDuration = 10f; // Dur�e du boost en secondes

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController playerController = other.GetComponent<FirstPersonController>();
            if (playerController != null)
            {
                playerController.JumpHeight *= jumpMultiplier; // Multiplier la force de saut du joueur
                Invoke("ResetJump", boostDuration); // R�tablir la force de saut normale du joueur apr�s la dur�e du boost
            }

            gameObject.SetActive(false); // D�sactiver l'objet "jump boost"
        }
    }

    private void ResetJump()
    {
        FirstPersonController playerController = FindObjectOfType<FirstPersonController>();
        if (playerController != null)
        {
            playerController.JumpHeight /= jumpMultiplier; // R�tablir la force de saut normale du joueur
        }
    }
}
