using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLogic : MonoBehaviour
{
    float m_speed = 0;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        float height = this.transform.position.y;
        float dy = m_speed * Time.deltaTime;

        if( dy > 0 && height < 4 )
        {
            this.transform.Translate(0, dy, 0, Space.Self);
        }
        if ( dy < 0 && height > 0)
        {
            this.transform.Translate(0, dy, 0, Space.Self);
        }       
    }

    public void Fly()
    {
        m_speed = 1;
    }
    public void Land()
    {
        m_speed = -1;
    }

    public void stop()
    {
        m_speed = 0;
    }
}
