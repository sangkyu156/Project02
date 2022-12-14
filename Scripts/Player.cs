using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10; 

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    Animator animator;
    Vector2 vector2;

    public enum Eirection
    {
        Up,Down,Left,Right
    }
    Eirection eirection = Eirection.Down;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {

    }
    void Update()
    {
        //이동
        vector2.x = Input.GetAxisRaw("Horizontal");
        vector2.y = Input.GetAxisRaw("Vertical");

        rigidbody2D.velocity = vector2.normalized * moveSpeed;

        //멈춰있을때
        if(rigidbody2D.velocity.x == 0 && rigidbody2D.velocity.y == 0)
        {
            switch (eirection)
            {
                case Eirection.Up:
                    animator.SetBool("U_Idle", true);
                    break;
                case Eirection.Down:
                    break;
                case Eirection.Left:
                    break;
                case Eirection.Right:
                    break;
                default:
                    break;
            }
        }





        //방향전환
        if (vector2.x == -1)//왼쪽
        {
            spriteRenderer.flipX = false;
            eirection = Eirection.Left;
        }
        else if(vector2.x == 1)//오른쪽
        {
            spriteRenderer.flipX = true;
            eirection = Eirection.Right;
        }
    }
}
