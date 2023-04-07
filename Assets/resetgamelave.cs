using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetgamelave : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Il y a collision avec le joueur");
            FindObjectOfType<PlayerTP>().ResetPosition();
            GetComponent<cubelave>().ResetPosition();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}