using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void onMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void onExit()
    {
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif 
    }
}
