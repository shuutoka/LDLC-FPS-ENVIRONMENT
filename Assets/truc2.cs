using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // R�f�rence au transform du joueur
    public float speed = 5f; // Vitesse de d�placement

    private void Update()
    {
        // Calcule la direction vers le joueur
        Vector3 direction = (player.position - transform.position).normalized;

        // D�place l'objet "Truc" dans la direction du joueur avec une vitesse constante
        if (gameObject.name == "Truc")
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}