using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TierList : MonoBehaviour
{
    

    public int numOfXMarks;
    
    public Image[] xMark;

    public int xMarkCount;

    public PlayerControl player;

    // Update is called once per frame
    void Update()
    {
        xMarkCount = player.scale;

        for(int i = 0; i < xMark.Length; i++)
        {
            if (i < xMarkCount)
            {
                xMark[i].enabled = true;
            }
            else
            {
                xMark[i].enabled = false;
            }
        }
    }
}
