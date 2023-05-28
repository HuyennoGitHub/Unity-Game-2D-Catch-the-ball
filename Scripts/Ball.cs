using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;

    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
            Debug.Log("Va cham voi gia do");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
            Debug.Log("GameOver");
        }
    }
}
