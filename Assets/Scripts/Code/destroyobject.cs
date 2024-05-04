using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class destroyobject : MonoBehaviour
{
   // public XRbaseinteratable inter;
    public GameObject othergame;
   // public GameObject mony;
    public GameObject seed;
    public GameObject[] flower;
    // Start is called before the first frame update
    void Start()
    {
        GameObject othergame = GetComponent<GameObject>();
        //mony.SetActive(false);
        seed.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void destroy(){
        Destroy(othergame);
        if(flower.Length >0 ){
            foreach(GameObject go in flower){
                Destroy(go);
            }
        }
        
       // Destroy(GameObject.FindGameObjectWithTag ("Flower"));
       // mony.SetActive(false);
        seed.SetActive(true);

    }
}
