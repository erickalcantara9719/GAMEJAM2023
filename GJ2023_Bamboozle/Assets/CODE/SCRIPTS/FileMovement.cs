using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class FileMovement : MonoBehaviour
{
    float countdownForPos;
    public float countdownForLeaving;
    float moveSpeed;
    public float maxMoveSpeed;
    public float minMoveSpeed;
    public float minFlightX, maxFlightX, minFlightY, maxFlightY;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(minMoveSpeed, maxMoveSpeed);
        countdownForPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(countdownForPos>0)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed);
            countdownForPos -= Time.deltaTime;
        }
        else if (countdownForPos<=0 || transform.position==targetPosition)
        {
            targetPosition = new Vector3(Random.Range(minFlightX, maxFlightX), Random.Range(minFlightY, maxFlightY), transform.position.z);
            countdownForPos = Random.Range(1.0f, 3.0f);
        }
        
    }
}
