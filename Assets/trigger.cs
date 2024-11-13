using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 NewPosition;
    public Vector3 SizeofMove;
    void Start()
    {
        transform.position = NewPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += SizeofMove * Time.deltaTime;
        if (transform.position .x >4)
            SizeofMove.x = -SizeofMove.x;

        if (transform.position.x < -4)
            SizeofMove.x = -SizeofMove.x;

        if (transform.position.y > 4)
            SizeofMove.y = -SizeofMove.y;

        if (transform.position.y < -4)
            SizeofMove.y = -SizeofMove.y;

        if (transform.position.z > 4)
            SizeofMove.z = -SizeofMove.z;

        if (transform.position.z < -4)
            SizeofMove.z = -SizeofMove.z;



    }
}
