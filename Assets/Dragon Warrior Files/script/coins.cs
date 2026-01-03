
using UnityEngine;

public class coins : MonoBehaviour
{
    public AudioClip coisounds; 
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
            AudioSource.PlayClipAtPoint(coisounds,transform.position);

            moneytext.Coin += 1;
            Destroy(gameObject);
        }
    }
}
