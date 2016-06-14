using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuCTRL : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
