using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 initialVelocity = Vector2.zero;

    private void Start()
    {
		StartBallMovement();
    }

 
    private void StartBallMovement()
	{
		initialVelocity = initialVelocity * (-1);
		rb.velocity = initialVelocity;//previousVelocity;
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
		string collidedObjTag = collision.gameObject.tag;
		if (collidedObjTag == "bottomWall")
        {
            rb.isKinematic = true;
            GameManager.instance.GameEnd();
        }
	}

}
