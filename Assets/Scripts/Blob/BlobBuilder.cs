using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobBuilder : MonoBehaviour
{
    Mesh mesh;
    MeshFilter meshFilter;
    float length;
    float width;
    Vector3[] originalVertices;
    Vector3[] deformedVertices;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
        //originalVertices = meshFilter.mesh.vertices;
        //deformedVertices = originalVertices;
        //for(int i = 0; i < originalVertices.Length; i++)
        //{
        //    deformedVertices[i] = originalVertices[i] + new Vector3(0.5f, 0.5f, 0.0f) * .1f/(Mathf.Clamp(Vector3.Distance(new Vector3(-.4f, -.4f, .0f), originalVertices[i]),.1f,1e10f));
        //}
        
    }
    private void Start()
    {
        //meshFilter.mesh.vertices = deformedVertices;
    }

    private void Update()
    {
        originalVertices = meshFilter.mesh.vertices;
        deformedVertices = originalVertices;
        for (int i = 0; i < originalVertices.Length; i++)
        {
            deformedVertices[i] = originalVertices[i] + new Vector3(0.005f, 0.005f, 0.0f) * 
                5.0f * .001f / Mathf.Pow((Mathf.Clamp(Vector3.Distance(new Vector3(.0f, .0f, .0f), originalVertices[i]), .001f, 1e10f)), 0.5f);
        }
        meshFilter.mesh.vertices = deformedVertices;
    }
}
