using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void PressButtonPlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
