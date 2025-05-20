using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawmOnFall : MonoBehaviour
{
    
    void Start()
    {
        
    }
     
    
    void Update()
    {
        if (transform.position.y < -25)
        {
            Debug.Log("Perdiste xd");
            SceneManager.LoadScene("FPSparkour");
        }
    }
}
