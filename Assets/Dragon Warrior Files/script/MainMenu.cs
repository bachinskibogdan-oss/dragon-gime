using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void loallvl()
    {
        SceneManager.LoadScene("SampleScene");
}
    public void Exitgame()
    {
        Application.Quit();

    }


}
