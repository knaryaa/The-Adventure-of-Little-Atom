using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyFish : MonoBehaviour
{
    public GameObject fish;
    public int tier;
    public int score;
    
    private PlayerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(player.scale < tier)
            {
                player.anim.SetTrigger("Attack");
                SoundManager.PlaySound("enemyEat");
                player.size += 1;
                player.totalScore += score;
                Destroy(fish);

            }
            else if(player.scale >= tier)
            {
                player.totalScore -= score/2;
                player.anim.SetTrigger("Hit");
                player.Hit();
                SoundManager.PlaySound("enemyBad");
                Destroy(fish);
            }
            
        }
        else if (collision.CompareTag("Wall"))
        {
            Destroy(fish);
        }
    }
}
