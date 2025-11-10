using UnityEngine;
using UnityEngine.UI;

public class healtsBar : MonoBehaviour
{
    public gealth playerHealth;
    public Image totalHeart;
    public Image currnetHeart;
    // Start is called before the first frame update
    void Start()
    {
        totalHeart.fillAmount = playerHealth.curentheals / 10;

    }

    // Update is called once per frame
    void Update()
    {
        currnetHeart.fillAmount = playerHealth.curentheals / 10;


    }
}
