using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnvironmentManager : MonoBehaviour
{

    public ObstacleManager obstacleManager;
    public GameObject paddleObj;
    public GameObject ballPrefabObj;

    public GameObject ballObj;

    

    public void OnGameStart()
    {
        SpawnObstacle();
        SpawnBall();
        paddleObj.SetActive(true);
    }

    public void OnGameOver()
    {
       
        obstacleManager.DeleteAllObstacles();
        paddleObj.SetActive(false);
        Destroy(ballObj, 1.0f);
    }

    private void SpawnBall()
    {
        ballObj = Instantiate(ballPrefabObj, paddleObj.transform, false);
      
    }

    private void SpawnObstacle()
    {
        obstacleManager.SpawnObstacle();
    }
}
