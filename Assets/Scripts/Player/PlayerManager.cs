using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public PlayerInput playerInput;
    SpriteRenderer spriter;
    Animator anim;

    public Rigidbody2D rb;
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
        spriter.flipX = (moveVec.x > 0 ? false : true); //바라보는 방향으로 오브젝트를 플립시킴
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();
        if (context.phase == InputActionPhase.Started) { anim.SetBool("isRun", true); }
        else if (context.phase == InputActionPhase.Canceled) { anim.SetBool("isRun", false); }
    }

    /*
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started) { Gamemanager.instance.pool.Get(1); }
    }
    */
}
