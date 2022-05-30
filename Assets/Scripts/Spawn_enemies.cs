using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_enemies : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    [SerializeField] private GameObject enemy;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", spawnRate, spawnRate);
    }

    private void SpawnEnemies()
    {
        Instantiate(enemy, new Vector2(Random.Range(-9.6f, 9.6f), 7), Quaternion.identity);
    }
}
