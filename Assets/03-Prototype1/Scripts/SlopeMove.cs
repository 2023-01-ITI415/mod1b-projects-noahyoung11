using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeMove : MonoBehaviour
{
    public GameObject slopeMovePrefab;
    public float speed = 1f;
    public float chanceToChangeDirections = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -20){
            speed = Mathf.Abs(speed);
        } else if(pos.x > -3){
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate(){
        if(Random.value < chanceToChangeDirections){
            speed*=-1;
        }
    }
}
