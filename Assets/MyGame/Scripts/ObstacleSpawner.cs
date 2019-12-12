using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public bool gameOver = false;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        float waitTime = 0.5f;

        while (!gameOver)
        {
            SpawnObstacle();

            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle,transform.position,Quaternion.identity);
    }
}
