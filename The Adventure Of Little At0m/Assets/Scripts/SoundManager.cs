using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip enemyEat,enemyBad;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        enemyEat = Resources.Load<AudioClip>("enemyEat");
        enemyBad = Resources.Load<AudioClip>("enemyBad");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "enemyEat":
                audioSrc.PlayOneShot(enemyEat);
                break;
            case "enemyBad":
                audioSrc.PlayOneShot(enemyBad);
                break;
        
        }
    }
}
