using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube")) // Si le joueur entre en collision avec l'objet "Cube"
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // On recharge la scène actuelle
        }
    }
}
