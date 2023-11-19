using System;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform RespawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ServiceLocator.instance.GetService<CheckpointManager>().CurrentCheckpoint = RespawnPosition.position;
        }
    }
}