using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redémarer : MonoBehaviour

{
    bool timer = false;
    float TimerCount = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerStay(Collider Other){
        timer = true;
        if (timer == true)
        {
            if(TimerCount > 0){
                TimerCount -= 1 * Time.deltaTime;
            }
            else{
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
        
    }
}
