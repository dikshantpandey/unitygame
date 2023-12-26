using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controls : MonoBehaviour
{

   /* [SerializeField] private GameObject player;

    private Rigidbody2D playerRb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    [SerializeField] private LayerMask jumpableGround;
    //[SerializeField] private Joystick joystick;

    private float dirX = 0;

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpForce = 14f;

    private bool setLeft=false;
    private bool setRight=false;

    private enum MovementState { idle, running, jumping, falling, previous }

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    private void Awake()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
        boxCollider = player.GetComponent<BoxCollider2D>();
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(setLeft)
        {
            moveLeft();
        }
        else if(setRight)
        {
            moveRight();
        }
        else { 
            Debug.Log("IDLE");
            UpdateAnimationState(MovementState.idle);
        }
    }

    private void setVelocity(int dirX)
    {
        playerRb.velocity = new Vector2(dirX * moveSpeed, playerRb.velocity.y);
    }

    private void UpdateAnimationState(MovementState state)
    {
        if (state != MovementState.previous)
        {
            animator.SetInteger("state", (int)state);
            Debug.Log("state :: " + state + ":::" + (int)state);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    private void moveLeft()
    {
        setVelocity(-1);
        MovementState state = MovementState.running;
        state = MovementState.running;
        spriteRenderer.flipX = true;
        UpdateAnimationState(state);
    }

    private void moveRight()
    {
        setVelocity(1);
        MovementState state = MovementState.running;
        spriteRenderer.flipX = false;
        UpdateAnimationState(state);
    }

    public void jump()
    {
        MovementState state = MovementState.previous;
        if (IsGrounded())
        {
            state = MovementState.jumping;
            jumpSoundEffect.Play();
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
        UpdateAnimationState(state);
    }

    public void enableLeft()
    {
        setLeft=true;
    }

    public void disableLeft()
    {
        setLeft = false;
    }

    public void enableRight()
    {
        setRight = true;
    }

    public void disableRight()
    {
        setRight = false;
    }
*/
}
