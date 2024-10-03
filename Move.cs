﻿using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 2f;
    void Start() {

        //direction = goal.transform.position - transform.position;
       
        //this.transform.Translate(direction);
    }

    private void LateUpdate() {

        direction = goal.transform.position - transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 1)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
