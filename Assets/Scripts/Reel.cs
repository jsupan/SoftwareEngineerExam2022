using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel : MonoBehaviour
{
    [HideInInspector] public bool spin = false;

    public int speed = 1500;
    public int resetPosition = 600;

    RectTransform parentRectTransform;
    void Start()
    {
        parentRectTransform = transform.parent.GetComponent<RectTransform>();
    }

    void Update()
    {
        if (spin)
        {
            foreach (Transform image in transform)
            {
                image.transform.Translate(speed * Time.smoothDeltaTime * Vector3.down, Space.World);

                if (image.transform.position.y <= 0)
                {
                    image.transform.position = new Vector3(image.transform.position.x, image.transform.position.y + resetPosition, image.transform.position.z);
                }
            }
        }
    }

    public void RandomPosition()
    {
        List<int> parts = new()
        {
            226,
            113,
            0,
            -113,
            -226,
            -339,
            -452,
            -565,
            -678,
            -791,
        };

        int rand = Random.Range(0, parts.Count);
        int i = rand;

        foreach (Transform image in transform)
        {
            if (parts.Count > i)
            {
                image.transform.position = new Vector3(image.transform.position.x, parts[i] + parentRectTransform.transform.position.y, image.transform.position.z);
            }
            else
            {
                i = 0;
                image.transform.position = new Vector3(image.transform.position.x, parts[i] + parentRectTransform.transform.position.y, image.transform.position.z);
            }
            i++;
        }
    }
}
