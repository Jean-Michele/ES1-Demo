using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class disparaitre : MonoBehaviour
{
    [SerializeReference] private GameObject _bye;
    // Start is called before the first frame update
    public void Bye()
    {
        _bye.SetActive(false);
    }
}
