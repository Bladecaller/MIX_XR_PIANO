using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideUpScript : MonoBehaviour
{
    GameObject keyboard;

    void Start(){
        keyboard = GameObject.Find("Keyboard");
    }

    void OnTriggerEnter(Collider other){
        Vector3 temp = keyboard.transform.localPosition;
        temp.y += 0.01f;
        keyboard.transform.localPosition = temp;
    }
}
