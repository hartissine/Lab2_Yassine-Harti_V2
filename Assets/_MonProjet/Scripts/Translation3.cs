using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation3 : MonoBehaviour
{
    public float Vitesse = 30;
    public Vector3 Offset = new Vector3(-46, 0, -18);
    public float rotation = 180;

    private int direction = 1;

    void FixedUpdate()
    {
        if (transform.position.x > Offset.z)
        {
            direction = -1;
            transform.Rotate(0, rotation, 0);
        }
        if (transform.position.x < Offset.x)
        {
            direction = 1;
            transform.Rotate(0, -(rotation), 0);
        }
        transform.position = transform.position + new Vector3(Vitesse * direction * Time.deltaTime, 0, 0);
    }
}
