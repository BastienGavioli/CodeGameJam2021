using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Level;
    public GameObject helpPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(Level);
    }

    public void HelpWindowOpen()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }

    public void SettingsOppening()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
