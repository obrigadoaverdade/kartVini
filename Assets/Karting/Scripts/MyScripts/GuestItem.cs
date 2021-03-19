using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestItem : MonoBehaviour
{

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180); //giro
        transform.position += Vector3.up * Mathf.Sin(Time.time) * 0.02f; //sobe e desce
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
             other.gameObject.SendMessage("ItemCollected");
                                      
            //Debug.Break();
            audio.Play();
            Destroy(gameObject, 0.5f);
        }

        
    }
}
