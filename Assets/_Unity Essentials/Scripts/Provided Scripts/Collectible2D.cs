using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other) {
         Destroy(gameObject);
          Instantiate(onCollectEffect, transform.position, transform.rotation);
         // Check if the other object has a PlayerController2D component
        if (other.GetComponent<PlayerController2D>() != null) { 
            Destroy(gameObject);

            // Instantiate the particle effect
           
        }

        
    } 


}


