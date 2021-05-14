using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rBody;

    public float count;
    public Text countText; 

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

        count = 0;
        countText.text = "";
    }

    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
            countText.text = "Game Over";

        }

        if(target.gameObject.CompareTag("Brick"))
        {
            Destroy(target.gameObject);
            Count();
        }

        if(count >= 75)
        {
           countText.text = "Game Over"; 
        }
    }

    void Count()
    {
        count = count + 1;
        countText.text = "Score : " + count.ToString(); 
    }

}
