using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean_Motion : MonoBehaviour
{
    public float scale;
    public float waveSpeed;
    public float waveHeight;
    
    void Update()
    {
        CalcNoise();
    }
    
    void CalcNoise()
    {
            MeshFilter mF = GetComponent<MeshFilter>();
    
            Vector3[] verts = mF.mesh.vertices;
    
            for (int i = 0; i < verts.Length; i++)
            {
                float pX = (verts[i].x * scale) + (Time.time * waveSpeed);
                float pZ = (verts[i].z * scale) + (Time.time * waveSpeed);
    
                verts[i].y = Mathf.PerlinNoise(pX, pZ) * waveHeight;
            }
    
            mF.mesh.vertices = verts;
    
            mF.mesh.RecalculateNormals();
    
            mF.mesh.RecalculateBounds();
    }
    
}
