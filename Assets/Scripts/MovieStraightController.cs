using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieStraightController : MonoBehaviour
{
    public Vector2 velocity;
    new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = velocity;
    }
}
