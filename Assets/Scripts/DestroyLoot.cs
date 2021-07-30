using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLoot : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Loot collided with " + other);
            Destroy(this.gameObject);
        }

    }
}
