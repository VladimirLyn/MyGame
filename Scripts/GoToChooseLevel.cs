using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToChooseLevel : MonoBehaviour
{
    public void PressButtonChooseLevel()
    {
        SceneManager.LoadScene("WhatLevel");
    }
}
