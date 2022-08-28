using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelAndHero : MonoBehaviour
{

    bool ChooseHero;
    public static GameObject Player;
    public static GameObject PlayerMage;
    public static GameObject PlayerWarior;
    /*
    public void PressButtonSelectMage()
    {
        Player = PlayerMage;
        ChooseHero = true;
    }
    public void PressButtonSelectWarior()
    {
        Player = PlayerWarior;
        ChooseHero = true;
    }
    */
    public void PressButtonSelectLevelForest()
    {
            SceneManager.LoadScene("ForestLevel");
        
       
    }
    public void PressButtonSelectLevelDesert()
    {
            SceneManager.LoadScene("DesertLevel");
        
       
        
    }
}

public static class Global
{
    public static bool UnderWater;
    public static bool HaveBall;
}

