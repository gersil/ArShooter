using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ducks;
    private Vector3 PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for (int i = 0; i < ducks.Length; i++)
        {
            PlayerPos = GameObject.FindGameObjectWithTag("MainCamera").transform.position;

            Instantiate(ducks[i], new Vector3(PlayerPos.x + Random.Range(-10,15), PlayerPos.y + Random.Range(-10,15), PlayerPos.z + Random.Range(-10,15)), spawnPoints[i].rotation);
        }
        StartCoroutine(StartSpawning());
    }
  
}
