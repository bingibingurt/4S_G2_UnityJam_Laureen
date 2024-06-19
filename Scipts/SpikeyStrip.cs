using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeyStrip : MonoBehaviour
{
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Die();

        }

    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;

    }

    private void RestardLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
