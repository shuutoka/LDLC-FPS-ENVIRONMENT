using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTP : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;
    // Start is called before the first frame update
    void Start()
    {
        //ICI JE RECUPERE LA POSITION DE DEPART DU JOUEUR GRACE A transform.position

        lastCheckpointPosition = transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //JE REGARDE SI LE PERSONNAGE EST TROP BAS
        if (transform.position.y <= -5f)
        {
            //SI C'EST LE CAS, JE LE DEPLACE A LA POSITION DE DEPART GRACE A transform.position
            transform.position = lastCheckpointPosition;
        }
    }

    public void ResetPosition()
    {
        transform.position = lastCheckpointPosition;
    }

    public void SetCheckpointPosition(Vector3 position)
    {
        lastCheckpointPosition = position;
    }
}
