using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButterfly : MonoBehaviour
{
    void Update(){
       transform.Translate(0f, Input.GetAxis("Vertical")*10f*Time.deltaTime, 0f); 
       transform.Translate(Input.GetAxis("Horizontal")*10f*Time.deltaTime, 0f, 0f); 
    }
}
