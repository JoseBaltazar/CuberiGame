using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string levelName;
    public GameObject loadImage;

    public void NewGame()
    {
        GameObject.Find("Dif").SetActive(true);
        loadImage.SetActive(true);
        //SceneManager.LoadScene(levelName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(2);
    }
}
