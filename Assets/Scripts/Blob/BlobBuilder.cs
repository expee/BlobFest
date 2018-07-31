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
    float farthestDistance;
    float disposition;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Start()
    {
        farthestDistance = 0;
        originalVertices = new Vector3[meshFilter.mesh.vertices.Length];
        deformedVertices = new Vector3[meshFilter.mesh.vertices.Length];
        originalVertices = (Vector3[]) meshFilter.mesh.vertices.Clone();
        for(int i = 0; i < originalVertices.Length; i++)
        {
            float distance = Vector3.Distance(originalVertices[i], Vector3.zero);
            if (distance > farthestDistance)
            {
                farthestDistance = distance;
            }
        }
        disposition = .0f;
    }

    private void Update()
    {
        disposition += .0001f;
        for (int i = 0; i < originalVertices.Length; i++)
        {
            deformedVertices[i] = originalVertices[i] +
                new Vector3(-disposition, 0.0f, 0.0f) *
                .01f/Mathf.Pow(Mathf.Clamp(Vector3.Distance(new Vector3(0.296f, 0.01799f, 0.0f), originalVertices[i]), .01f, 1.0e10f),2);
        }
        meshFilter.mesh.vertices = deformedVertices;
    }
}
