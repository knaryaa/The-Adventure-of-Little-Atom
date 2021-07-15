using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    public float speed;
    public int size;
    public int scale;
    public int maxHealth;
    public int currentHealth;
    public int totalScore;


    public Color colorGreen;

    public Animator anim;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public GameObject player;
    public float scaleX, scaleY;

    public Text scoreText;
    public Text scoreTextWin;
    public Text scoreTextLose;
    public Text tierUp;
    public Text tierLevel;

    public MainMenu menu;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        scaleX = 0.1f;
        scaleY = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        scoreText.text = totalScore.ToString();
        scoreTextWin.text = totalScore.ToString();
        scoreTextLose.text = totalScore.ToString();
        tierUp.text = size.ToString((size)+"/15");
        tierLevel.text = scale.ToString(scale+"/7");

        Scale();
        Flip();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    void Flip()
    {
        Vector3 rotation = transform.eulerAngles;
        if (Input.GetAxisRaw("Horizontal")>0)
        {
            rotation.y = 180;
        }
        else if(Input.GetAxisRaw("Horizontal")<0)
        {
            rotation.y = 0;
        }
        transform.eulerAngles = rotation;
    }

    void Scale()
    {
        if (size > 15 && scale < 7)
        {
            scale++;
            size = 1;
            player.transform.localScale = new Vector2(scaleX+0.08f, scaleY+0.08f);
            scaleX += 0.08f;
            scaleY += 0.08f;
            speed += speed / 200;
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {

        }
    }

    public void Hit()
    {
        currentHealth -= 1;
        if (currentHealth == 0)
        {
            Death();
        }
    }

    public void Death()
    {

        if (scale < 7)
        {
            Debug.Log("Kaybetti");

            menu.Lose();


        }
        else if (scale == 7)
        {
            menu.Win();
        }
        Destroy(this);
    }
}