using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    private float SpawnFast = 0.005f;
    private float SpawnFastFirst = 1f;
    public GameObject[] Targets;
    public GameObject[] Spawners;
    public int SpawnerChooser = 0;

    void Start()
    {
        StartCoroutine(TargetsSpawner());
    }
    IEnumerator TargetsSpawner()
    {
        while (true)
        {
            Instantiate(Targets[Random.Range(0, 4)], Spawners[Random.Range(0,4)].gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(SpawnFastFirst -= SpawnFast);
            if (SpawnFastFirst <= 0.5f)
            {
                break;
            }
        }
    }
}
