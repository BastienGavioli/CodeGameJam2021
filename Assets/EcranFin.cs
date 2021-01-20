using UnityEngine;
using UnityEngine.SceneManagement;

public class EcranFin : MonoBehaviour
{
    public string Level;
    public GameObject panel;

    public void LoadMenu()
    {
        SceneManager.LoadScene(Level);
    }
    public void OpenPanel()
    {
        panel.SetActive(true);
    }
}
