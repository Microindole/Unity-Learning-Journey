using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLogic : MonoBehaviour
{
    public Material[] colors;
    int m_index = 0;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void ChangeColor()
    {
        Material color = this.colors[m_index];
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = color;
        Debug.Log(" Change -> " + m_index + ", time = " + Time.time);
        if (m_index == 0)
        {
            Invoke("ChangeColor", 4);
        }
        else if (m_index == 1)
        {
            Invoke("ChangeColor", 4);
        }
        else if (m_index == 2)
        {
            Invoke("ChangeColor", 1);
        }
        m_index = (m_index + 1) % colors.Length;
    }
}
