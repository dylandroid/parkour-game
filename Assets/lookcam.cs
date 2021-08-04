using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookcam : MonoBehaviour
{
    public Transform player;
    public Transform self;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        self.position = player.position;
    }
}
