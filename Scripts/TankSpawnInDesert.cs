using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnInDesert : MonoBehaviour
{
    public GameObject Anemy;
    int SecondsToSpawn = 40;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            if (SecondsToSpawn < 10) SecondsToSpawn--;

            Instantiate(Anemy, new Vector3(54, -40, -260), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);
        }
    }
}
