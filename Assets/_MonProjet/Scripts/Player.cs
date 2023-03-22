using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vitesse = 800;
    [SerializeField] private float _rotation = 200;
    private Rigidbody _rb;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {        
            MouvementsJoueur();
    }
    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        _rb.velocity = direction.normalized * Time.fixedDeltaTime * _vitesse;

        if (direction.magnitude >=0.1f)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotation * Time.fixedDeltaTime);
        }

    }
    
    // Update is called once per frame
    
    public void finPartieJoueur()
    {
        this.gameObject.SetActive(false); // pour faire disparaitre le joueur

    }
}
