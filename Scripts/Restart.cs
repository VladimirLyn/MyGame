using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void PresButtonRestartThisLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().name.ToString()));
    }
}
