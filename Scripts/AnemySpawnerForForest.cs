using System.Collections;
using UnityEngine;

public class AnemySpawnerForForest : MonoBehaviour
{
    public GameObject Anemy;
    int SecondsToSpawn = 30;

    private void Start()
    {
        StartCoroutine(SpawnAnemyInLocation(SecondsToSpawn, Anemy));
    }
    public IEnumerator SpawnAnemyInLocation(int sec, GameObject Anemy)
    {
        while (true)
        {
            if (SecondsToSpawn > 5) SecondsToSpawn--;
            Instantiate(Anemy, new Vector3(-41, 3, -40), Quaternion.identity);
            Instantiate(Anemy, new Vector3(- 35, 3, -30), Quaternion.identity);
            Instantiate(Anemy, new Vector3(-40, 3, -35), Quaternion.identity);
            Instantiate(Anemy, new Vector3(- 42, 3, -30), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);

        }

    }
}
