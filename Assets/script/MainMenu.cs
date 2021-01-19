using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Level;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(Level);
    }

    public void LoadGame()
    {

    }

    public void HelpWindowOpen()
    {

    }

    public void SettingsOppening()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
