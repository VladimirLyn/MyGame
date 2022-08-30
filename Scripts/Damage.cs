using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Image PlayerHelthBar;
    public Text PlayerHelthText;
    float HP = 100;
    public Button HealButton;
    bool StartHeal = false;
    int i;
    public void OnTriggerStay(Collider Col)
    {
        if (gameObject.tag == "Player")
        {
            switch (Col.tag)
            {
                case ("fire"):
                    {
                        HP -= 0.5f;
                        break;
                    }
                case ("anemy"):
                    {
                        HP -= 0.5f;
                        break;
                    }
                case ("heal"):
                    {
                        if (HP < 100 && StartHeal == true)
                        {
                            HP += 50;
                            StartCoroutine(DeactivateAndActivate(60, Col.GameObject()));
                        }
                        break;
                    }
                case ("tank"):
                    {
                        HP -= 0.2f;
                        break;
                    }
                case ("boss"):
                    {
                        HP -= 1f;
                        break;
                    }
            }
        }
    }

    private void FixedUpdate()
    {
        i = Convert.ToInt32(HP);
        if (HP > 100) HP = 100;
        PlayerHelthText.text = i.ToString();
        PlayerHelthBar.fillAmount = HP / 100;
        if (HP <= 0) SceneManager.LoadScene("DethScene");
    }

    public IEnumerator DeactivateAndActivate(float TimePerSeconds, GameObject obj)
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(TimePerSeconds);
        obj.SetActive(true);
    }

    public IEnumerator CanHeal()
    {
        StartHeal = true;
        yield return new WaitForSeconds(1);
        StartHeal = false;
    }


    public void PressButtonHeal()
    {
        StartCoroutine(CanHeal());
    }
}
