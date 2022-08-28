using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnemySpawnerForDesert : MonoBehaviour
{
    public GameObject Anemy;
    int SecondsToSpawn = 30;
    Vector3[] SpawmPoints;

    private void Start()
    {
        Vector3[] SpawmPoints = { new Vector3(10, -37, -260), new Vector3(54, -40, -260), new Vector3(20, -37, -260), new Vector3(-42, -37, -260) };

        StartCoroutine(SpawnAnemyInLocation(SecondsToSpawn, Anemy));
    }
    public IEnumerator SpawnAnemyInLocation(int sec, GameObject Anemy)
    {
        while (true)
        {
            if (SecondsToSpawn > 5) SecondsToSpawn--;
            Instantiate(Anemy, new Vector3(10, -37, -260), Quaternion.identity);
            Instantiate(Anemy, new Vector3(54, -40, -260), Quaternion.identity);
            Instantiate(Anemy, new Vector3(20, -37, -260), Quaternion.identity);
            Instantiate(Anemy, new Vector3(-42, -37, -260), Quaternion.identity);
            yield return new WaitForSeconds(SecondsToSpawn);
        }

    }
}
