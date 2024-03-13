using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private Transform obstacleRB;
    public float obstacleSpawnDelay = 2f;
    public float obstacleSpeed = 3f;
    private float obstacleHeight;

    private void Start()
    {
        StartCoroutine(ChangeHeight());
    }

    IEnumerator ChangeHeight()
    {
        while (true)
        {
            obstacleHeight = Random.Range(-4, 4);
            obstacleRB.transform.position = new Vector3(transform.position.x, obstacleHeight, 0);
            ChangeHeight();
            Spawn();
            yield return new WaitForSeconds(obstacleSpawnDelay);
        }
    }

    private void Spawn()
    {
        GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        GameObject spawnedObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>();
        obstacleRB.velocity = Vector2.left * obstacleSpeed;
    }
}
