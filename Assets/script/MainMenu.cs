using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Level;
    public GameObject helpPanel;
    public GameObject creditsPanel;
    public GameObject settingsPanel;

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

    public void CreditsOpen()
    {
        creditsPanel.SetActive(true);
    }

    public void CreditsClose()
    {
        creditsPanel.SetActive(false);
    }

    public void SettingsOppening()
    {
        settingsPanel.SetActive(true);
    }

    public void SettingsClosing()
    {
        settingsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
