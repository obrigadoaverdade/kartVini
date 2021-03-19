using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompBala : MonoBehaviour
{
    //Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player;
        player = GameObject.Find("KartClassic_Player");

        GetComponent<Rigidbody>().AddForce(player.transform.forward * 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
