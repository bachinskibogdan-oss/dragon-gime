using UnityEngine;

public class dedzoni : MonoBehaviour
{
    public float damageEnemy;
    public Transform pos3, pos4;


    private void Start()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.GetComponent<gealth>().TakeDamage(damageEnemy);
            Destroy(gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos3.position, pos4.position);
    }
}
