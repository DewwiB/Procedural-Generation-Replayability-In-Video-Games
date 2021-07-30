using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Room"))
        {
            Debug.Log("Destroyer collided with " + other); // check what it's colliding with
            Destroy(other.gameObject);
        }  

    }
    
}
