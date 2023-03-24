using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation1 : MonoBehaviour
{
    // ***** Attributs *****

    public float Vitesse = 30;
    public Vector3 Offset = new Vector3(22, 0, -22); // Établi l'offset de la position du gameObject
    public float rotation = 180;
    private int direction = 1;

    // ***** Méthodes privées *****

    void FixedUpdate()
    {

        if (transform.position.x > Offset.x) // etalement de la translation sur l'axe des X avec le changement de direction 
        {
            direction = -1;
            transform.Rotate(0, rotation, 0);
        }
        if (transform.position.x < Offset.z) // etalement de la translation sur l'axe des X avec le changement de direction 
        {
            direction = 1;
            transform.Rotate(0, -(rotation), 0);
        }
        // transform.Translate(direction * Time.deltaTime * _vitesse);
        transform.position = transform.position + new Vector3(Vitesse * direction * Time.deltaTime, 0, 0);      // Établi une translation du gameObject sur l'axe x
    }

}
