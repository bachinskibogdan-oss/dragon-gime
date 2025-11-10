
using UnityEngine;

public class healtfruit : MonoBehaviour
{
    public float heal;
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
        if (collision.gameObject.CompareTag("player"))
        {
            collision.GetComponent<gealth>().AddHils(heal);
            Destroy(gameObject);
        }
    }

}
