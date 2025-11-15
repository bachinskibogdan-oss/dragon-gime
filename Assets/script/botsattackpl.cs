using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class botsattackpl : MonoBehaviour
{
    public float damageEnemy;
    public float curentheals;
    public bool isSpikel;
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
            collision.GetComponent<gealth>().TakeDamage(damageEnemy);
        }
    }
}
