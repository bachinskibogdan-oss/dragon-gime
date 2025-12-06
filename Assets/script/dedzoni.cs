using UnityEngine;

public class dedzoni : MonoBehaviour
{
    public float damageEnemy;
    public Transform pos3, pos4;
    public GameObject respawn;
    public GameObject player;

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
        if (collision.gameObject.CompareTag("player"))
        {
            player.transform.position = respawn.transform.position;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos3.position, pos4.position);
    }
}
