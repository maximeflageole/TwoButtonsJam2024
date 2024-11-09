using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject m_grassPrefab;

    private void Awake()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
    }

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(m_grassPrefab, transform.position + new Vector3(i - 5, 0, 0), Quaternion.identity);
        }
    }

}
