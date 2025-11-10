
using UnityEngine;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            moneytext.Coin += 1;
            Destroy(gameObject);
        }
    }
}
