using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject parentObj;
    public GameObject obstaclePrefab;
	

    public float itemSize = .33f;
	public float gap = 0.1f;
	
    private List<GameObject> obstacleList = new List<GameObject>();

	public int totalObstacleNumber = 100;
	public float maxRightPos_X = 2.5f;
	public float maxLeftPos_X = -2.5f;
	public float startYPos = 5;


	private int itemPerRow = 1;

    private void Start()
    {
		SpawnObstacle();

	}

    public void SpawnObstacle()
	{
		for (int i = 0; i < totalObstacleNumber; i++)
		{
			GameObject obstacle = obstaclePrefab;
			GameObject obj = InstantiateObject(obstacle.gameObject);
			Vector2 pos = GetPos(i);
			//Debug.Log("ItemPos " + pos);
			obj.transform.position = new Vector3(pos.x, pos.y);
			obstacleList.Add(obj);
		}
	
	}

	private Vector2 GetPos(int itemNumber)
    {
		float perItemSize = itemSize + gap;

		itemPerRow =  ((int)(Mathf.Ceil(Mathf.Abs(maxLeftPos_X) + Mathf.Abs(maxRightPos_X)) / perItemSize)) + 1;
		//Debug.Log("U>> per row " + itemPerRow);

		int currentRow = (itemNumber) / itemPerRow;
		int currentColumn = Mathf.Abs(itemNumber - (currentRow * itemPerRow));
		float xPos = (perItemSize * currentColumn) + maxLeftPos_X;
		float yPos = startYPos - (currentRow * perItemSize);

        return new Vector2(xPos, yPos);
	}

	private GameObject InstantiateObject(GameObject obj)
	{
		GameObject newObj = Instantiate(obj, parentObj.transform, false);
		newObj.transform.parent = parentObj.transform;
		return newObj;
	}

	public void DeleteAllObstacles()
    {
		for (int i = 0; i < obstacleList.Count; i++)
        {
			Destroy(obstacleList[i].gameObject);
        }
		obstacleList = new List<GameObject>();

	}
}
