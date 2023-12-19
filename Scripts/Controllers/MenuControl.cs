using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public string gameScene;

    public void NewGame()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}