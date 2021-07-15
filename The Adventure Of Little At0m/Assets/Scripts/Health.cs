using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public PlayerControl player;
    public int health;
    public GameObject healthBar;

    Image image;

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        health = player.currentHealth;
        HealthDecrease();
    }

    public void HealthDecrease()
    {
        if(health == 5)
        {
            image.sprite = sprite0;
        }
        if (health == 4)
        {
            image.sprite = sprite1;
        }
        if (health == 3)
        {
            image.sprite = sprite2;
        }
        if (health == 2)
        {
            image.sprite = sprite3;
        }
        if (health == 1)
        {
            image.sprite = sprite4;
        }
        if (health == 0)
        {
            image.sprite = sprite5;
        }

    }
}
