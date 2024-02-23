using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplan : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    public void Moveplan(float x, float z){
        _sphere.Rotate(x,0,z,Space.World);
    }
    private void Update() {
        if(Input.GetKey(KeyCode.A)){
            Moveplan(0f,0.01f);
        }
        if(Input.GetKey(KeyCode.D)){
            Moveplan(0f,-0.01f);
        }
        if(Input.GetKey(KeyCode.S)){
            Moveplan(-0.01f,0f);
        }
        if(Input.GetKey(KeyCode.W)){
            Moveplan(0.01f,0f);
        }
    }
}
