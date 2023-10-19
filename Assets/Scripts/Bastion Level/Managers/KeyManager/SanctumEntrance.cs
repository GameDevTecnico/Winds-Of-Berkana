using System.Collections.Generic;
using UnityEngine;

public class SanctumEntrance : MonoBehaviour
{
    public int NKeysToOpen = 0;
    [HideInInspector] public int PlacedKeys = 0;

    private List<GameObject> _altars = new();
    private bool _playerIsNear = false;

    public void UpdateKeys()
    {
        if (!_playerIsNear)
        {
            return;
        }

        KeyManager keyManager = ServiceLocator.instance.GetService<KeyManager>();

        if (keyManager.CollectedKeys <= 0)
        {
            return;
        }

        for (int i = PlacedKeys; i < keyManager.CollectedKeys; i++)
        {

            PlaceKey(_altars[i]);
            PlacedKeys++;
        }

        ServiceLocator.instance.GetService<Bastion1Manager>().PickUpKey(PlacedKeys);
    }

    private void Start()
    {
        if (NKeysToOpen == 0)
        {
            NKeysToOpen = transform.childCount;
        }

        foreach (Transform child in transform)
        {
            _altars.Add(child.gameObject);
        }

        ServiceLocator.instance.GetService<MainPlayerInputHandler>().Interact += UpdateKeys;
    }

    private void PlaceKey(GameObject altar)
    {
        Debug.Log("Placed");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerIsNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerIsNear = false;
        }
    }
}