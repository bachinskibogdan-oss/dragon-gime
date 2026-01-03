using UnityEngine;
using UnityEngine.UI;

public class moneytext : MonoBehaviour
{
    public static int Coin;
     Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        if (text == null)
        {
            Debug.LogError("");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (text != null)
        {
            text.text = Coin.ToString();
        }
    }
}
    