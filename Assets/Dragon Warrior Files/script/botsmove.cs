using UnityEngine;

public class botsmove : MonoBehaviour
{
    public float speed = 5f; // Скорость движения объекта 
    public float distance = 1f; // Расстояние, на которое объект будет двигаться влево и вправо 

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= startPos.x + distance)
        {
            movingRight = false;
        }
        else if (transform.position.x <= startPos.x - distance)
        {
            movingRight = true;
        }
    }
}
