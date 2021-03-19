using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBala : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform bala;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(bala, transform.position, Quaternion.identity);

        }
        
    }
}
