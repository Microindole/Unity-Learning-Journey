using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    int m_index = 0;
    Vector3 pos = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeShape();
        }

    }
    public void ChangeShape()
    {
        pos.z++;
        Transform child = this.transform.GetChild(m_index);
        child.gameObject.SetActive(false);

        m_index = (m_index + 1) % 3;

        child = this.transform.GetChild(m_index);
        child.gameObject.SetActive(true);

        child.position = pos;

    }
}
