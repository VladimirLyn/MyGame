using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Image PlayerHelthBar;
    public Text PlayerHelthText;
    float HP = 100;

    private void Start()
    {
        PlayerHelthText.text = HP.ToString();
    }

    void OnTriggerStay(Collider Col)
    {
        if (Col.tag == "fire") HP--;
    }
    void OnTriggerExit(Collider Col)
    {
        if (Col.tag == "fire") HP--;
    }
    private void FixedUpdate()
    {
        PlayerHelthText.text = HP.ToString();
        PlayerHelthBar.fillAmount = HP/100;
        if (HP <= 0) SceneManager.LoadScene("DethScene");
    }
}
