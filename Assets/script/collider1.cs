using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider1 : MonoBehaviour
{
    [SerializeField] private Transform _player,_plan;
    private void OnCollisionEnter(Collision other) {
        _player.position = new Vector3(2.87f,3.37f,-1.43f);
        var v3 = new Vector3(-0.54f,0,0);
        Vector3 rotate = transform.eulerAngles;
        rotate.x = -0.54f;
        rotate.y = 0;
        rotate.z = 0;
        _plan.rotation = Quaternion.Euler(rotate);
        text.timer = 0;
    }
}
