using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] List<GameObject> Obstacles;
    private void Start()
    {
        StartCoroutine(startGeneratingObstacle());
    }

    IEnumerator startGeneratingObstacle()
    {
        yield return new WaitForSeconds(3);
        GenerateObstacle();
    }

    private void GenerateObstacle()
    {
        int NumberOfObstacle = Random.Range(15, 25);
        for (int i = 0; i < NumberOfObstacle; i++)
        {
            int k = Random.Range(0, Obstacles.Count);
            float xPos = Random.Range(-13, 14);
            float yPos = 2;
            float zPos = Random.Range(transform.position.z, transform.position.z + 200);
            Vector3 obsPos = new Vector3(xPos, yPos, zPos);
            GameObject temp = Instantiate(Obstacles[k], obsPos, Quaternion.identity);
            temp.transform.parent = gameObject.transform;
        }
    }
}
