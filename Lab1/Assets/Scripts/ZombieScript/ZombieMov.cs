using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMov : MonoBehaviour
{
    //Reference to unity chan character
    public Transform unityChan;


    // Start is called before the first frame update
    void Start()
    {
        //finding the transform of unity chan
        unityChan = GameObject.FindGameObjectWithTag("Unity").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating zombie to face unity chan. Then applying a movement speed to the zombie.
        transform.LookAt(unityChan);
        transform.position += transform.forward * 2.0f * Time.deltaTime;
    }


}
