using System.Collections;
using UnityEngine;

public class TankSpawnInForest : MonoBehaviour
{
    public GameObject Anemy;
    int SecondsToSpawn = 40;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while(true)
            {
            if (SecondsToSpawn < 10) SecondsToSpawn--;
            
            Instantiate(Anemy, new Vector3(-40, 3, -35), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);
        }
    }
}
