using UnityEngine;

public class moveplatform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed = 1f;
    public Transform startpos;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startpos.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        if (transform.position == pos1.position){
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position) { 
        nextPos = pos1.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
