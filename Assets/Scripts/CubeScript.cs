using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    AudioSource src;
    public AudioClip note;

    void Start(){
    src = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Tip"){ //&& other.gameObject.GetComponent<Rigidbody>().velocity.y > 0.5f){
            src.PlayOneShot(note);
        }
    }
}
