using UnityEngine;
using UnityEngine.UI;

public class botshp : MonoBehaviour
{
    public float starthealth;
    public float curentheals;
    public float damageEnemy;
    // Start is called before the first frame update
    void Start()
    {
        curentheals = starthealth;
    }
    // Update is called once per frame
    void Update()
    {



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.GetComponent<gealth>().TakeDamage(damageEnemy);
            Destroy(gameObject);
        }
    }

}
