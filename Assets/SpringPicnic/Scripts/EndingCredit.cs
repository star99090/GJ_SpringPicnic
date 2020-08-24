using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCredit : MonoBehaviour
{
    Vector3 move = new Vector3(0f, 0.015f, 0f);
    float timer;

    void Update()
    {
        if (this.transform.position.y != -20f)
        {
            this.transform.position -= move;
        }
    }
}
