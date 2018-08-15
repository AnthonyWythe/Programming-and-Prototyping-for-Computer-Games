using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPause : MonoBehaviour {

    public Transform point0;            //The first waypoint
    public Transform point1;            //The second waypoint
    public Transform point2;            //the third waypoint

    public GameObject NPC;              //Reference to the character model
    Rigidbody rb;                       //Reference to the models rigidbody component
    Animator anim;                     //Reference to the models animator component

    public int moveSpeed;               //The movement speed
    public int smooth;                  //The amount of smooth on turning

    bool moving = true;                 //Is the character moving or not
    bool updated = false;

    Transform currentPoint;             //The last point reached in the path
    Transform newPoint;                 //The point being moved towards
    int proximity = 2;                  //Proximity from the new point


    //Initialises the variables//
    void Start()
    {
        //Sets up the components from the model
        rb = NPC.GetComponent<Rigidbody>();
        anim = NPC.GetComponent<Animator>();

        //Starts the path
        currentPoint = point0;
        newPoint = point1;
    }


    //Main update method to control the movement//
    void Update()
    {
        //If the character is not near the way point, face it and start approaching it//
        if (Vector3.Distance(transform.position, newPoint.position) > proximity && moving == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(newPoint.position - transform.position), smooth * Time.deltaTime);
            rb.MovePosition(transform.position += transform.forward * moveSpeed * Time.deltaTime);
        }

        //If the character is within the proximity of the way point, set to idle and pause before moving to the next one//
        if (Vector3.Distance(transform.position, newPoint.position) < proximity && updated == false)
        {
            moving = false;
            anim.SetBool("Moving", false);
            StartCoroutine(Wait());
            UpdatePoint();
        }

        //Ensures the point only updates once//
        updated = false;

    }


    //Method to update the current and new way point, set to follow a specific path//
    public void UpdatePoint()
    {
        if (currentPoint == point0 && newPoint == point1)
        {
            currentPoint = point1;
            newPoint = point2;
        }
        else if (currentPoint == point1 && newPoint == point2)
        {
            currentPoint = point2;
            newPoint = point1;
        }
        else if (currentPoint == point2 && newPoint == point1)
        {
            currentPoint = point1;
            newPoint = point0;
        }
        else if (currentPoint == point1 && newPoint == point0)
        {
            currentPoint = point0;
            newPoint = point1;
        }

        //Ensures the waypoint doesnt update more than once
        updated = true;
    }


    //Coroutine to make the model wait at each waypoint for 5 seconds//
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(4,20));
        moving = true;
        anim.SetBool("Moving", true);
    }
}
