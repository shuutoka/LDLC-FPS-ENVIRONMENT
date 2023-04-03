using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Référence au transform du joueur
    public float speed = 5f; // Vitesse de déplacement

    private void Update()
    {
        // Calcule la direction vers le joueur
        Vector3 direction = (player.position - transform.position).normalized;

        // Déplace l'objet "Truc" dans la direction du joueur avec une vitesse constante
        if (gameObject.name == "Truc")
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}