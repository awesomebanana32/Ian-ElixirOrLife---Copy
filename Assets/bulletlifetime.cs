using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletlifetime : MonoBehaviour
{
    float bulletLifetimeInSeconds = .5f;
    // Start is called before the first frame update
    void Start()
    {
     
    }


    private void Awake()
    {
        Destroy(gameObject, bulletLifetimeInSeconds);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
