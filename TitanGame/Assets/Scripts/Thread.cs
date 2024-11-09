using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thread : MonoBehaviour
{
    [SerializeField]
    private LineRenderer m_lineRenderer;
    private void Start()
    {
        var cam = Camera.main;
        var leftSide = cam.ScreenToWorldPoint(new Vector3(0,Screen.height/3.0f, 10.0f));
        var rightSide = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 3.0f, 10.0f));
        m_lineRenderer.SetPosition(0, leftSide);
        m_lineRenderer.SetPosition(1, rightSide);
    }
}
