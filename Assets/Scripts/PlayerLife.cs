using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private Animator animator;
    private Rigidbody2D player;
    [SerializeField] private AudioSource deathSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        player.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
        deathSoundEffect.Play();
    }

    private void RestartLevel() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
