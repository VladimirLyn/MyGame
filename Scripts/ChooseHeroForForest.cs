using UnityEngine;

public class ChooseHeroForForest : MonoBehaviour
{
    public GameObject Mage;
    public GameObject Warior;

    public void PressButtonChooseMage()
    {
        Instantiate(Mage, new Vector3(5, 2, 2), Quaternion.identity);
        gameObject.SetActive(false);
    }
    public void PressButtonChooseWarior()
    {
        Instantiate(Warior, new Vector3(5, 2, 2), Quaternion.identity);
        gameObject.SetActive(false);
    }
}
