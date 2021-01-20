using UnityEngine;
using UnityEngine.SceneManagement;

public class AffichagePanel : MonoBehaviour
{
    public GameObject lePanel;
    public string leMenu;

    public void LoadMenu()
    {
        SceneManager.LoadScene(leMenu);
    }

    public void Affichage()
    {
        lePanel.SetActive(true);
    }
}
