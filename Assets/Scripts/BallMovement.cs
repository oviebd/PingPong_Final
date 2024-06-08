using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 initialVelocity = Vector2.zero;
 //   public Vector2 maximumVelocity = new Vector2(50f, 50f);
	//private Vector2 previousVelocity;

    private void Start()
    {
		StartBallMovement();
    }

    public void StartBallMovement()
	{
		initialVelocity = initialVelocity * (-1);
		//SetBallVisibleAnbMoveAble(true);
		rb.velocity = initialVelocity;//previousVelocity;
	}

	public void StopBallMovement()
	{
	//	previousVelocity = rb.velocity;
		rb.velocity = Vector2.zero;
		//SetBallVisibleAnbMoveAble(false);

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
		string collidedObjTag = collision.gameObject.tag;
		//Debug.Log("tag    " + collidedObjTag);
		if (collidedObjTag == "wall")
		{
			BoundaryBehaviour boundaryBehaviour = collision.gameObject.GetComponent<BoundaryBehaviour>();
			if (boundaryBehaviour != null)
			{
				//if (boundaryBehaviour.wallType == Walls.right)
				//{
				//	Debug.Log("changing right wall vel     ");
				//	rb.velocity = new Vector2(rb.velocity.x * -1, rb.velocity.y);
				//}
				//else if (boundaryBehaviour.wallType == Walls.left)
				//{
				//	rb.velocity = new Vector2(rb.velocity.x * -1, rb.velocity.y);
				//	Debug.Log("changing left wall vel     ");
				//}
			}
		}
	}

 //   public void onCollide(Collision2D colidedObj2D)
	//{
		
	//}

}
