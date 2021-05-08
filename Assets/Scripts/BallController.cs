using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float jumpInput = Input.GetAxis("Jump");

        rBody.AddForce(new Vector2(0, jumpInput));
    }

    
}
