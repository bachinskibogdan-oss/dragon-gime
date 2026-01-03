    using UnityEngine;

public class plantbullet : MonoBehaviour
{
    public float speed = 3f;
    public float timelive = 3f;
    public float damage = 0.5f;
    private Rigidbody2D rb;
    private gealth plhel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1, 0) * speed;
        Destroy(gameObject, timelive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.GetComponent<gealth>().TakeDamage(damage);
            Destroy(gameObject);

        }
    }
}
