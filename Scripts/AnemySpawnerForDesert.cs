using System.Collections;
using UnityEngine;

public class AnemySpawnerForDesert : MonoBehaviour
{
    public GameObject Anemy;
    int SecondsToSpawn = 20;

    private void Start()
    {
        StartCoroutine(SpawnAnemyInLocation(SecondsToSpawn, Anemy));
    }
    public IEnumerator SpawnAnemyInLocation(int sec, GameObject Anemy)
    {
        while (true)
        {
            if (SecondsToSpawn > 5) SecondsToSpawn--;
            Instantiate(Anemy, new Vector3(10, -37, -260), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);
        }

    }
  
}
