using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

    }

    void Update()
    {
        transform.Rotate(2.0f * Time.deltaTime, Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));


        Material material = Renderer.material;

        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.2f, 1.0f));


        if (transform.localScale.x < 3.5f && transform.localScale.x >= 0.0f)
        {
            float temp = transform.localScale.x;
            temp += Random.Range(-0.1f, 0.1f);
            transform.localScale = new Vector3(temp, temp, temp);
        }
        else if (transform.localScale.x <= 0.0f || transform.localScale.x >= 3.5f)
            transform.localScale = Vector3.one * 1.7f;
    }
}
