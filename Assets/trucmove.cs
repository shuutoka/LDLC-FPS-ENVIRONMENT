using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 5f; // vitesse de d�placement
    public float changeTime = 2f; // temps de changement de direction

    private Rigidbody rb;
    private float timer;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timer = changeTime;
        direction = Random.insideUnitSphere.normalized; // direction al�atoire
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = Random.insideUnitSphere.normalized; // changer de direction al�atoirement
            timer = changeTime;
        }

        rb.MovePosition(transform.position + direction * speed * Time.deltaTime); // d�placement
    }
}