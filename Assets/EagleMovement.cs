using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed;

    Transform NextPos;

    int NextPoxIndex;

    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if(transform.position == NextPos.position)
        {
            NextPoxIndex++;
            if(NextPoxIndex >= Positions.Length)
            {
                NextPoxIndex = 0;
            }
            NextPos = Positions[NextPoxIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
        }
    }
}
