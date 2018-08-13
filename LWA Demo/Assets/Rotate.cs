using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float speed = 30f;
    public bool rl = false;
    public bool rr = false;
	public void Update()
	{
        if(rl){
            RotateLeft();
        }
        if (rr)
        {
            RotateRight();
        }
	}
	public void RotateLeft()
    {
        rl = true;
        rr = false;
        this.gameObject.transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    public void RotateRight()
    {
        rr = true;
        rl = false;
        this.gameObject.transform.Rotate(Vector3.down, speed * Time.deltaTime);
    }
    public void StopRotating(){
        rr = false;
        rl = false;
    }
}
