using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPatrol : MonoBehaviour
{
    public float speed;
    //private float waitTime;
    //public float startWaitTime;

    public Transform moveSpot;
    public float moveX;
    public float moveY;


    // Start is called before the first frame update
    void Start()
    {
        //waitTime = startWaitTime;
        moveSpot.position = new Vector2(moveX, moveY);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        /**if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)

        {
            if (waitTime <= 0)
            { 
                moveSpot.position = new Vector2(moveX, moveY);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }*/
    }
}
