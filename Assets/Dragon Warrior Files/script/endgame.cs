using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    private bool pick;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        pick = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            pick = true;
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene 1");
        }
    }
    }




