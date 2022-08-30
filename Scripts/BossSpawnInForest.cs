using System.Collections;
using UnityEngine;

public class BossSpawnInForest : MonoBehaviour
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

            Instantiate(Anemy, new Vector3(-42, 3, -30), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);
        }
    }
}
