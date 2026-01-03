using UnityEngine;

public class turelweapon : MonoBehaviour
{
    [Header("настройка стрельбы")]
    public Transform shotpos;
    public GameObject bullet;
    public float firetime = 1f;
    public Vector2 shotdirection = Vector2.left;
        public float damageEnemy;
    private float nextfiretime;
    public float curentheals;
    // Start is called before the first frame update
    void Start()
    {
       // shotdirection = shotdirection.normalized;
       // float angel = Mathf.Atan2(shotdirection.y, shotdirection.x) * Mathf.Rad2Deg;
       // transform.rotation = Quaternion.AngleAxis(angel, Vector3.forward);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextfiretime) {
            Sgoot();
               nextfiretime = Time.time + 1f/firetime;
        }


    }
    void Sgoot()
    {
        Instantiate(bullet,shotpos.position,shotpos.rotation);      



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.GetComponent<healths>().TakeDamage(damageEnemy);
            Destroy(gameObject);
        }
    }
}


