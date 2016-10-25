using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Restart()
    {
        //Application.LoadLevel(Application.loadedLevel);
    }

    public void NewGame()
    {
        //Application.LoadLevel(1);
        SceneManager.LoadScene("demo");
    }

    public void Options()
    {
        print("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
