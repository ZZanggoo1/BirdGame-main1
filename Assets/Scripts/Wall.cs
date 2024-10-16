using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public float speed=2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Vertical"))
        {
            speed += 1;
        }

        if (Input.GetButtonDown("Vertical"))
        {
            speed -= 1;
        }
    }
    // 화살표 상하 버튼을 이용하여 speed를 조절할 수 있도록 설계

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

        if (transform.position.x<-10)
        {
            Destroy(gameObject);
        }
    }

}
