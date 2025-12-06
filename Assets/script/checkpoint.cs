using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private dedzoni respawn;
    private BoxCollider2D Chkpnt;
    // Start is called before the first frame update
    void Start()
    {
        Chkpnt = GetComponent<BoxCollider2D>();
        GameObject respawnObject = GameObject.FindGameObjectWithTag("dedzome");
        if (respawnObject != null)
        {
            respawn = respawnObject.GetComponent<dedzoni>();
            Debug.Log("Yes");

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            respawn.respawn = this.gameObject;
            Chkpnt.enabled = false;  
        }
    }
}
