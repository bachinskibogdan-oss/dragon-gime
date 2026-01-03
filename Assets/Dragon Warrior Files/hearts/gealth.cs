using System.Collections;
using UnityEngine;

public class gealth : MonoBehaviour
{
    public float starthealth;
    public float curentheals;
    private Animator anim;
    private bool dead;
    public float iframesDr;
    public int numof;
    private SpriteRenderer srr;


    // Start is called before the first frame update
    void Start()
    {
        curentheals = starthealth;
        anim = GetComponent<Animator>();
        srr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float _damage)
    {
        curentheals = Mathf.Clamp(curentheals - _damage, 0, starthealth);
        if (curentheals > 0)
        {
            StartCoroutine(Flashes());


        }
        else {
            if (!dead)
            {
                anim.SetTrigger("dead");
                dead = true;
                GetComponent<plauercontrilir>().enabled = false;
                Destroy(gameObject, 0.6f);
            }
         


        }
       

    }
    public void AddHils(float _Values) { 
        curentheals = Mathf.Clamp(curentheals + _Values, 0, starthealth);
        
    }
    private IEnumerator Flashes()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        for (int i = 0;i < numof; i++)
        {
            srr.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iframesDr / (numof * 2));
            srr.color = Color.white;
            yield return new WaitForSeconds(iframesDr / (numof * 2));
            anim.SetBool("takedamage", true);
        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }




}
