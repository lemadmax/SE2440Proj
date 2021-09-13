using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    Transform bar;

    void Start()
    {
        bar = transform.Find("Bar");
    }

    public void SetBar(Vector3 newBar)
    {
        transform.right = -Camera.main.transform.right;
        transform.forward = -Camera.main.transform.forward;
        bar.transform.localScale = newBar;
    }
}
