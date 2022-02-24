using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size_bloom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _distance = Vector3.Distance(this.transform.position, player.position);
        if(_distance > 40f)
        {
            _distance = 40f;
        }
        transform.localScale = new Vector3(_distance, _distance, _distance);
    }
}