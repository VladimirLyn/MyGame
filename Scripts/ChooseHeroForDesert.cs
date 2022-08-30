using UnityEngine;

public class ChooseHeroForDesert : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warior;
    
    public void PressButtonChooseMage()
    {
        Instantiate(Mage,new Vector3(15,-35,-180),Quaternion.identity);
        gameObject.SetActive(false);
    }
    public void PressButtonChooseWarior()
    {
        Instantiate(Warior, new Vector3(15, -35, -180), Quaternion.identity);
        gameObject.SetActive(false);
    }

}
