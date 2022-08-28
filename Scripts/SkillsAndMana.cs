using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkillsAndMana : MonoBehaviour
{
    public Image PlayerManaBar;
    public Text PlayerManaText;
    public int ManaMultiplier;
    float Mana;
    public GameObject SkillExp;
    public GameObject SkillFire;
    int i;
    private void Start()
    {
        Mana = 100 * ManaMultiplier;
    }
    private void FixedUpdate()
    {
        if (Mana > 100 * ManaMultiplier) Mana = 100 * ManaMultiplier;
        i = Convert.ToInt32(Mana);
        PlayerManaText.text = i.ToString();
        PlayerManaBar.fillAmount = Mana / 100 / ManaMultiplier;
        Mana += 0.02f * ManaMultiplier;
    }
    public IEnumerator StartSkillExp()
    {
        if(Mana > 50)
        {
            SkillExp.SetActive(true);
            Mana -= 50;
            yield return new WaitForSeconds(0.2f);
            SkillExp.SetActive(false);
        }
    }
    public void PressButtonSkillExp()
    {
        StartCoroutine(StartSkillExp());
    }
    public IEnumerator StartSkill()
    {
        if (Mana > 40)
        {
            SkillFire.SetActive(true);
            Mana -= 40;
            yield return new WaitForSeconds(1);
            SkillFire.SetActive(false);
        }
    }
    public void PressButtonSkillFire()
    {
        StartCoroutine(StartSkill());
    }

}
