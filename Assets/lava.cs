using UnityEngine;

public class lava : MonoBehaviour
{
    public float speed = 5.0f; // Vitesse de levage de la plateforme

    private bool isMovingUp = false; // Variable booléenne pour déterminer si la plateforme est en train de monter
    private Vector3 startPosition; // Position de départ de la plateforme

    void Start()
    {
        startPosition = transform.position; // On enregistre la position de départ de la plateforme
    }

    void Update()
    {
        if (isMovingUp) // Si la plateforme est en train de monter
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime); // On déplace la plateforme vers le haut en fonction de la vitesse de levage
        }
    }

    public void StartMovingUp() // Méthode pour commencer à lever la plateforme
    {
        isMovingUp = true;
    }
}
