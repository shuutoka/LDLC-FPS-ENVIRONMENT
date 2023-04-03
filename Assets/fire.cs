using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pan;
    public float projectileSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        //Effectuer une action lorsque l'utilisateur clique (dans l'Update) :
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("J'ai cliqué sur le bouton");
            
        }
    }
}
