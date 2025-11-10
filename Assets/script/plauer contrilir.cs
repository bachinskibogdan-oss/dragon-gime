
using Unity.VisualScripting;
using UnityEngine;

public class plauercontrilir : MonoBehaviour
{
    public float moveSpeed = 5f;//Скорость движения
    public float jumpForce = 5f;//сила прижка 
    private Rigidbody2D rb;//компонент Rigidbody2D
    public bool isGroundedl;//на земле или нет?
    private Animator anim;//комонент Animator



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//получаем Rigidbody2D
        anim = GetComponent<Animator>();//получаем Animator
    }

    
    void Update()
    {
        Move();
        Jump();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
           this.transform.parent = collision.transform;
        }


        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("platform"))
        {
            isGroundedl = true;
            anim.SetBool("Jump",false);//деактивируем прыжок
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            this.transform.parent = null;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGroundedl = false;
        }

    }
    
    private void Move(){
        float horiz = Input.GetAxis("Horizontal");//Получаем ввод с клавы   
        rb.velocity = new Vector2(horiz * moveSpeed, rb.velocity.y);//изменяем скорость по x

        anim.SetBool("Walk",horiz != 0);//передаём состояние бега в Animator

        //поворот в сторону движения
        if (horiz > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void Jump()
    {
        
        //Прыжок
        if (isGroundedl == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
            anim.SetBool("Jump", true);//активируем прыжок
        }
    }



}
