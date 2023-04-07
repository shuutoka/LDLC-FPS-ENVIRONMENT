using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cubelave : MonoBehaviour
{
    public TMP_Text Mort; 
        int morts;

    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        lastKnownPosition = transform.position;
        morts = 0;
        Mort.text = "Death Counter : " + morts; 
    }
   public Vector3 lastKnownPosition;

    public void ResetPosition()
    {
        transform.position = lastKnownPosition;
        morts ++; 
        Mort.text = "Death Counter = " + morts;
    }

    public void SavePosition()
    {
        lastKnownPosition = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = new Vector3(0f, 1f, 0f);
        float speed = 0.02f;

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}
