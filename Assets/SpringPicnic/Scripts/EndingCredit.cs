using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCredit : MonoBehaviour
{
    Vector3 move = new Vector3(0f, 0.025f, 0f);

    void Update()
    {
        if (this.transform.position.y >= -30f)
        {
            this.transform.position -= move;
        }
    }
}
