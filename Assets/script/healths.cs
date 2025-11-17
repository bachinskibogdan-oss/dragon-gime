using UnityEngine;

public class healths : MonoBehaviour
{
    public float starthealth;
    public float curentheals;


    // Start is called before the first frame update
    void Start()
    {
        curentheals = starthealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float _damage)
    {
        curentheals = Mathf.Clamp(curentheals - _damage, 0, starthealth);

        if (curentheals <= 0)
        {
            Destroy(gameObject);
        }
    }
}