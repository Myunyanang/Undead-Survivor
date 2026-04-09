using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public PlayerInput playerInput;
    SpriteRenderer spriter;
    Rigidbody2D rb;
    Animator anim;
    public Vector2 moveVec;

    public float speed = 4;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        rb.linearVelocity = new Vector2(moveVec.x * speed, moveVec.y * speed);
        spriter.flipX = (moveVec.x > 0 ? false : true); //멈췄을 때 플립 풀리는 거 해결해야 함.
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();
        if(context.phase == InputActionPhase.Started) { anim.SetBool("isRun", true); }
        else if(context.phase == InputActionPhase.Canceled) { anim.SetBool("isRun", false); }
    }
}
