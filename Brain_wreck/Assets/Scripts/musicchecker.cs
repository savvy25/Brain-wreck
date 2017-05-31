using UnityEngine;
using System.Collections;
using System;



public class musicchecker : MonoBehaviour {

    public GameObject music;
    public GameObject[] G;


    // Use this for initialization
    void Start () {

        


        if (G != null)
        {
            Instantiate(music, Vector3.zero, Quaternion.identity);

        }
        
    


       



}

    

}
