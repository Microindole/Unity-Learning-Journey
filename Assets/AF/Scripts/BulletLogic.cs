using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public float speed;

    public float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        float lifetime = 1;
        if (speed > 0)
        {
            lifetime = maxDistance / speed;
        }
        Invoke("SelfDestroy", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed, Space.Self);
    }

    private void SelfDestroy()
    {
        Debug.Log("* ×Óµ¯×Ô»Ù£¡");
        Object.Destroy(this.gameObject);
    }
}
