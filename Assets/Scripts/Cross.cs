using UnityEngine;
using System.Collections;

public class Cross : MonoBehaviour
{
    public float speed = 2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TriggerCross();

        }
    }

    public void TriggerCross()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
