using System.Collections;
using UnityEngine;

public class AnemySpawnerForForest : MonoBehaviour
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
            Instantiate(Anemy, new Vector3(- 35, 3, -30), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);

        }

    }
}
