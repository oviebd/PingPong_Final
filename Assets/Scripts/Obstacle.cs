using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

	public AudioSource audioSource;
	public SpriteRenderer spriteRenderer;
	public Collider2D collider;
   

	private void OnCollisionEnter2D(Collision2D collision)
	{
		string collidedObjTag = collision.gameObject.tag;
		//Debug.Log("tag    " + collidedObjTag);
		if (collidedObjTag == "ball")
		{
			OnBallHit();
		}
	}


	private void OnBallHit()
    {
		audioSource.Play();
		spriteRenderer.enabled = false;
		collider.enabled = false;

		GameManager.instance.IncrementScore(1);
	}

}
