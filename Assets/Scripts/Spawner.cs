using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Spawn spawnPrefab;

    [FormerlySerializedAs("SpawnDurationInSeconds")] [SerializeField] private float spawnDurationInSeconds = 2;

    private SpawnShooter _spawnShooter;


    private void Start()
    {
        _spawnShooter = GetComponent<SpawnShooter>();
        NewSpawn();
    }


    public void NewSpawn()
    {
        _spawnShooter.ChangeCurrentSpawn(Instantiate(spawnPrefab.gameObject, transform.position, transform.rotation)
            .GetComponent<Spawn>());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Spawn>())
        {
            Invoke(nameof(NewSpawn), spawnDurationInSeconds);
        }
    }
}
