using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenuController : MonoBehaviour
{
    public void onStartClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void onExitClick()
    {
         {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif 
    }
    }
}
