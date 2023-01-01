using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Monster"))
        {
            //Destrtoy Player (hoding the script)
            Destroy(gameObject);
            //Destroy enemy  (the object player collided with)
            Destroy(collision.gameObject);
        }
    }

    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
