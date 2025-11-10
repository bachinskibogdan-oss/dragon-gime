using UnityEngine;

public class enemy : MonoBehaviour
{
    public class gealth : MonoBehaviour
    {
        public float starthealth;
        public float curentheals;
        private Animator anim;
        private bool dead;

        // Start is called before the first frame update
        void Start()
        {
            curentheals = starthealth;
            anim = GetComponent<Animator>();


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

            }
            if (curentheals <= 0)
            {
                Destroy(GameObject);
                dead = true;
                GetComponent<plauercontrilir>().enabled = false;
            }

        }
    }
}
