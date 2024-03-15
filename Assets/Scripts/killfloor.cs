using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killfloor : MonoBehaviour
{
   
    public Transform spawnPoint; // Set this in the Unity editor by dragging the spawn point object

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Teleport the player to the spawn point
            collision.transform.position = spawnPoint.position;
            
            // You can add visual/audio feedback here like player respawn animation or sound effect
        }
    }
}
