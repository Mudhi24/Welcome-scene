using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mangertoplay : MonoBehaviour
{
    public GameObject flowerpartical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
    public void playflower(string[]values){

        if(values[0]=="flower")


        flowerpartical.GetComponent<ParticleSystem>().Play();
    }
}
