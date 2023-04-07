using UnityEngine;

public class lava : MonoBehaviour
{
    public float speed = 5.0f; // Vitesse de levage de la plateforme

    private bool isMovingUp = false; // Variable bool�enne pour d�terminer si la plateforme est en train de monter
    private Vector3 startPosition; // Position de d�part de la plateforme
 
    void Update()
    {
        if (isMovingUp) // Si la plateforme est en train de monter
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime); // On d�place la plateforme vers le haut en fonction de la vitesse de levage
        }
    }

    public void StartMovingUp() // M�thode pour commencer � lever la plateforme
    {
        isMovingUp = true;
    }
}
