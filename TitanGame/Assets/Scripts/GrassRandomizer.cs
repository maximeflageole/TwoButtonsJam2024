using System.Collections.Generic;
using UnityEngine;

public class GrassRandomizer : MonoBehaviour
{
    [SerializeField]
    private List<SpriteRenderer> m_sprites;

    [SerializeField]
    private Gradient m_grassGradient;
    [SerializeField]
    private float m_minXSize;
    [SerializeField]
    private float m_maxXSize;
    [SerializeField]
    private float m_minYSize;
    [SerializeField]
    private float m_maxYSize;

    // Start is called before the first frame update
    void Start()
    {
        float index = -1;
        foreach (var sprite in m_sprites)
        {
            sprite.color = m_grassGradient.Evaluate(Random.value);
            var xSize = Random.Range(m_minXSize, m_maxXSize);
            var ySize = Random.Range(m_minYSize, m_maxYSize);
            sprite.transform.localScale = new Vector3(xSize, ySize, 1.0f);
            sprite.transform.position += new Vector3(index * Random.value, 0, 0);
            index++;
        }
    }
}
