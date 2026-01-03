using UnityEngine;

public class savesmt : MonoBehaviour
{
    private const string Coins_key = "Coincount";
    private const string healyh_key = "Healthcc";
    private const string pos_x_key = "Posxx";
    private const string pos_y_key = "Posyy";
    private const string Scene_key = "CurrentScene";

    public static savesmt Instance {get; private set;}



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Savepos(Vector2 position)
    {
        PlayerPrefs.SetFloat("Posxx" , position.x);
        PlayerPrefs.SetFloat("Posyy" , position.y);
        PlayerPrefs.Save();
    }
    public void CoinsCountSave(int coins)
    {
        PlayerPrefs.SetInt("Coincount", coins);
        PlayerPrefs.Save();
    }
    public void SaveHealths(float healths)
    {
        PlayerPrefs.SetFloat("Healthcc", healths);
        PlayerPrefs.Save();
    }
    public void SaveScene(string scene)
    {
        PlayerPrefs.SetString("CurrentScene", scene);
        PlayerPrefs.Save();
    }
    
}
