using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnvironmentManager : MonoBehaviour
{

    public ObstacleManager obstacleManager;
    public GameObject paddleObj;
    public GameObject ballObj;

    public void SpawnBall()
    {
        Vector3 parentPos = paddleObj.transform.position;
        GameObject newObj = Instantiate(ballObj, paddleObj.transform, false);
       // newObj.GetComponent<BallMovement>()
       // newObj.transform.parent = parentObj.transform;
    }

    public void SpawnObstacle()
    {
        obstacleManager.SpawnObstacle();
    }
}
