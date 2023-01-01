using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerControl : MonoBehaviour
{
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObj = GameObject.FindWithTag("Player");
        //transform.position is position of the gameobject that holds the script
        //gameObject.transform.position will be gameobject that is out player 
        //Vector3 v3 = (gameObj.transform.position - transform.position).normalized;
        //Vector2 v2 = new Vector2(v3.x, v3.y);
        if(gameObj != null)
        {
            Vector2 playerPos = (gameObj.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;
        }
    }

}
