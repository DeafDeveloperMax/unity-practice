using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    async void Start()
    {
        StartCoroutine("Random_P_R_C");
        transform.localScale = Vector3.one * 1.3f;
    }

    private IEnumerator Random_P_R_C()
    {
        while (true)
        {
            var random =  Random.Range(2, 4);
            
            RandomPosition_Rotation_Color();
            yield return new WaitForSeconds(random);
        }
    }

    void Update()
    {
        transform.Rotate(Random.Range(-10f, 10f * Time.deltaTime), Random.Range(-4.0f, 4.0f * Time.deltaTime), Random.Range(-8.0f, 8.0f * Time.deltaTime));
    }
    
    void RandomPosition_Rotation_Color()
    {
        Vector3 randomXYZ = new Vector3(Random.Range(0f, 4f), Random.Range(-11.0f, 9f), Random.Range(-11.0f, 18.04f));
        transform.position = randomXYZ;
        
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), 1.0f);
    }
}