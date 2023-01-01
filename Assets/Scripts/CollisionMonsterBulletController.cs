using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster") || collision.gameObject.CompareTag("Bullet"))
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            //Destroy Bullet itself
            Destroy(gameObject);
            //destroy item but not if wall
            if (!collision.gameObject.CompareTag("Wall"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
