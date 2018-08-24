using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeRotationSpeed : MonoBehaviour {

    public GameObject rotor;
    public Text speedText;
    public Text powered;
    public Text energy;
    public void changeSpeed()
    {
        int i = Mathf.FloorToInt(GetComponent<Slider>().value);
        rotor.GetComponent<loadingRotation>().speed = i;
        speedText.text = (i/6).ToString() + " mph";
        if(i> 250){
            powered.text = "City";
        }else{
            if(i > 100){
                powered.text = "Street";
            } else {
                if(i > 50){
                    powered.text = "House"; 
                }else{
                    if(i == 0){
                        powered.text = "Nothing";
                    }
                }
            }
        }

        energy.text = (.0006 * (i/12) * (i / 12) * (i / 12) * 1000 * 81 * .1).ToString() + " KWH";

    }
}
