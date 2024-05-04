using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{
    string num = null;
    int wordIndex =0 ;
    string alpha;
    public Text phoenumber = null;
    //public AudioSource aa;
   // string number1 = "330033";

    public void alphabetFunction (string alphabet){
        wordIndex++;
        num =num + alphabet;
        phoenumber.text =num;
        //chcktophone.text=number1;                                                               
        


       // if( num = number1 ){
               // aa.play();
        }

        public void plysoundbyclikingbutton(){
           // aa.Play()
        }
    
    }
    // Start is called before the first frame update

