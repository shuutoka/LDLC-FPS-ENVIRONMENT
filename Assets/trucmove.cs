using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 5f; // vitesse de déplacement
    public float changeTime = 2f; // temps de changement de direction

    private Rigidbody rb;
    private float timer;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timer = changeTime;
        direction = Random.insideUnitSphere.normalized; // direction aléatoire
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = Random.insideUnitSphere.normalized; // changer de direction aléatoirement
            timer = changeTime;
        }

        rb.MovePosition(transform.position + direction * speed * Time.deltaTime); // déplacement
    }
}