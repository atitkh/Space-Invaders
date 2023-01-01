using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log("Collision With Wall");
        if(!collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
