using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public static ObstacleManager instance;

    public GameObject parentObj;
    public GameObject obstaclePrefab;


	[SerializeField] private List<GameObject> _obstaclePrefabList;

    public float itemSize = .33f;
	public float gap = 0.1f;
	
    private List<GameObject> obstacleList = new List<GameObject>();

	public int totalObstacleNumber = 100;
	public float maxRightPos_X = 0;
	public float maxLeftPos_X = 0;
	public float startYPos = 0;


	private int itemPerRow = 1;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
		SpawnObstacle();
    }

	void SpawnObstacle()
	{

		

		//	objNumber = 100;
		for (int i = 0; i < totalObstacleNumber; i++)
		{
			GameObject obstacle = obstaclePrefab;
			GameObject obj = InstantiateObject(obstacle.gameObject);
			Vector2 pos = GetPos(i);
			//Debug.Log("ItemPos " + pos);
			obj.transform.position = new Vector3(pos.x, pos.y);


			//ObstacleBehaviour behaviour = obj.GetComponent<ObstacleBehaviour>();
			//if (behaviour != null)
			//{
			//	behaviour.SetUp();
			//	maxPointInLevel = maxPointInLevel + behaviour.GetObstacleClass().value;
			//}
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
		Vector3 parentPos = parentObj.transform.position;
		GameObject newObj = Instantiate(obj, parentObj.transform, false);
		newObj.transform.parent = parentObj.transform;
		return newObj;
	}
}
