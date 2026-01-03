using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public bool pausegame;
    public GameObject pasmen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausegame == true)
            {
                resume();
            }
            else {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pasmen.SetActive(true);
        pausegame = true;
        Time.timeScale = 0f;
    }
    public void resume()
    {
        pasmen.SetActive(false);
        pausegame = false;
        Time.timeScale = 1f;

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    

}
