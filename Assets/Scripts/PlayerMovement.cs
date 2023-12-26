using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    [SerializeField] private LayerMask jumpableGround;
    //[SerializeField] private Joystick joystick;
    
    private float dirX=0;
    private float dirY = 0;

    [SerializeField] private float moveSpeed=7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle, running, jumping ,falling }

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(Input.GetButton("left"));
        //dirX = Input.GetAxisRaw("Horizontal");
        dirX= SimpleInput.GetAxis("Horizontal");
        dirY = SimpleInput.GetAxis("Vertical");
        Debug.Log("xaxisXX::" + dirX);
        Debug.Log("xaxisYY::" + dirY);
        player.velocity = new Vector2(dirX *moveSpeed,player.velocity.y);

        if (Input.GetButtonDown("Jump") || dirY > 0.1f)
        {
            jump();
        }
        UpdateAnimationState();
    }

    public void jump()
    {
        if (IsGrounded())
        {
            jumpSoundEffect.Play();
            player.velocity = new Vector2(player.velocity.x, jumpForce);
        }
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        if (dirX > 0f)
        {
            state = MovementState.running;
            spriteRenderer.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            spriteRenderer.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }
        if(player.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if(player.velocity.y < 1f)
        {
            //state = MovementState.falling;
        }
        animator.SetInteger("state", (int)state);
        //Debug.Log("state :: "+state+":::" + (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
