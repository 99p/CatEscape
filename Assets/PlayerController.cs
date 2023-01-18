using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LbuttonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RbuttonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
