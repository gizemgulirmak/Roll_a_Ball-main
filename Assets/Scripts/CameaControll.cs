using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameaControll : MonoBehaviour
{
    public GameObject ball;
    public Vector3 aradakifark;
    // Start is called before the first frame update
    void Start()
    {
        aradakifark = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + aradakifark;
    }
}
