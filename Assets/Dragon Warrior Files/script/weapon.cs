using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform shotpos;
    public GameObject bullet;
    public AudioClip souhot;
    public AudioSource asss;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject newBullet = Instantiate(bullet, shotpos.transform.position, transform.rotation);
            bullet bulletscript = newBullet.GetComponent<bullet>();
            asss.PlayOneShot(souhot);
            if (transform.localScale.x > 0)
            {
                bulletscript.direction = 1;
            }
            else
            {
                bulletscript.direction = -1;
            }
        }
    }
}
