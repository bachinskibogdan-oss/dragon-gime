using UnityEngine;

public class dedzoni : MonoBehaviour
{
    private moveplatform player;

    private void Start()
    {
        player = GetComponent<moveplatform>();
        player.transform.position = new Vector2(0.76f, -0.61f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.transform.position = player.transform.position;
        }
    }
}
