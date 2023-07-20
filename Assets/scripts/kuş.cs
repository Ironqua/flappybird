using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kuş : MonoBehaviour
{
    public float velocity = 1f;
    private Rigidbody2D rb;
    public bool isDead;
    public gamemanager managergame;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // havada kuşu sıçrat
            rb.velocity = Vector2.up * velocity;


        }
    }

    private void OnTriggerEnter2D(Collider2D cls)
    {
        if (cls.gameObject.name.Equals("score")) //cls.gameobject.name=="score"
        {
            managergame.updatescore();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("deadarea"))
        {
            isDead = true;
            Time.timeScale = 0;
            SceneManager.LoadScene("bitiş");

        }
    }
}
