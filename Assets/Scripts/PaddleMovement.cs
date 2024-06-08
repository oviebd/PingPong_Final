using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

	public float paddleSpeed = 10.0f;
	public float maxLeftPos_X = -2.1f;
	public float maxRightPos_X = 2.1f;


	private void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
			MoveRight();
		if (Input.GetKey(KeyCode.LeftArrow))
			MoveLeft();
	}


	private void MoveRight()
	{
		SetMovement(true);
	}


	private void MoveLeft()
	{
		SetMovement(false);
	}

	private void SetMovement(bool isMoveRight)
	{
		//Debug.Log("Move " + isMoveRight);
		Vector3 position = this.transform.position;
		if (isMoveRight)
			position.x = position.x + (paddleSpeed * Time.deltaTime);
		else
			position.x = position.x - (paddleSpeed * Time.deltaTime);

        if (position.x > maxLeftPos_X &&
            position.x < maxRightPos_X)
            this.transform.position = position;
    }

}
