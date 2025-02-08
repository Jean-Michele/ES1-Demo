using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Red")){
            Destroy(collision.gameObject);
        }
    }
}
