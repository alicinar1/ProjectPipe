using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private float obstacleSpawnDistance = 40;
    [SerializeField] private Transform obstacleParent;
    private Vector3 obstaclePos;
    int obstacleIndex;
    float timeCounter;
    

    private void Update()
    {
            

        if (timeCounter > 1)
        {
            obstaclePos = new Vector3(0, 0, Player.Instance.transform.position.z + obstacleSpawnDistance);
            obstacleIndex = Mathf.RoundToInt(Random.Range(0, 11));
            Debug.Log(obstacleIndex);
            GameObject obstacle = Instantiate(obstaclePrefabs[obstacleIndex], obstaclePos, Quaternion.Euler(0f, 0f, Random.Range(0, 359)), this.gameObject.transform);
            timeCounter = 0;
        }

        timeCounter += Time.deltaTime;
    }

    private float PerlinRNG(float seed)
    {
        return Mathf.PerlinNoise(seed, timeCounter);
    }
}
