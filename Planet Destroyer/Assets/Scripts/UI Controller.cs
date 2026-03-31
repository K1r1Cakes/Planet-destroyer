using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public AudioSource audioSource;
    public void onMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
        audioSource.Play();
    }

    public void onExit()
    {
        audioSource.Play();

        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif 
    }

    public void onReset()
    {   
        audioSource.Play();
        PauseController.setPause(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
