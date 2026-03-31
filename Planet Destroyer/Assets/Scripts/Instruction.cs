using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
     public void onMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
