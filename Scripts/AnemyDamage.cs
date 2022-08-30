using UnityEngine;

public class AnemyDamage : MonoBehaviour
{
    public int AnemyHP = 200;

    public void OnTriggerStay(Collider Col)
    {
        switch (Col.tag)
        {
            case ("sword"):
                {
                    AnemyHP -= 2;
                    break;
                }
            case ("skillplasmaatack"):
                {
                    AnemyHP -= 40;
                    break;
                }
            case ("skillfireatack"):
                {
                    AnemyHP -= 4;
                    break;
                }
        }
    }
    private void FixedUpdate()
    {
        if (AnemyHP < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
