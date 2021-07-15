using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject movePoint;

    public Transform point;

    public float randX;
    public float randY;

    Vector2 whereToSpawn;
    Vector2 whereToSpawn2;
    public float spawnRate = 2f;
    float nextSpawn = 0f;

    public float minY;
    public float maxY;

    //public float fishCount;
    //public float maxFishCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(minY, maxY);
            whereToSpawn = new Vector2(randX, randY);
            //whereToSpawn2 = new Vector2(randX, randY+1);
            //GameObject point = Instantiate(movePoint, whereToSpawn2, Quaternion.identity);
            GameObject enemyfish = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            //fishCount++;

            //nemyfish.GetComponent<FishPatrol>().moveSpot = point.transform;
        }
    }
}
