using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementContoller : MonoBehaviour
{
    public float speed = 10f;
    private new Rigidbody2D rigidbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Here we get wether A or D  was pressed
        float h = Input.GetAxis("Horizontal");
        //Debug.Log("Vertical h is : " + h);

        //Here we get wether W or S  was pressed
        float v = Input.GetAxis("Vertical");
        //Debug.Log("Vertical v is : " + v);

        Vector2 dir = new Vector2(h, v);

        //Setting normalized speed of the player towards h and v directions
        rigidbody.velocity = dir.normalized * speed;

        animator.SetBool("isFlyingUp", v > 0);
        animator.SetBool("isFlyingBottom", v < 0);
        animator.SetBool("isFlyingLeft", h < 0);        
        animator.SetBool("isFlyingRight", h > 0);
    }
}
