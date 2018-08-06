using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySketch : MonoBehaviour {


    public GameObject plane; // to have access to our plane here

    Mesh mesh;
    List<Vector3> Verts = new List<Vector3>();
    public float jitterRange = 0.1f;
    public bool IsJitter = true;
	  // Use this for initialization
	void Start () {

        mesh = plane.GetComponent<MeshFilter>().mesh;
        Debug.Log("the plane has " + mesh.vertexCount + "verticies");
        //UpdateVertices();


    }
	
	// Update is called once per frame
	void Update () {
        UpdateVertices();
    }

    void UpdateVertices()
    {
        Verts.Clear();
        for (int i = 0; i < mesh.vertexCount; i++)
        {
            Vector3 newPos = mesh.vertices[i];

            int col = i % 10 ; // remainder for the first vertex is 1 so on, it becomes zero for the last vertex on the row
                
                //newPos.y += Random.Range(-jitterRange, jitterRange);
                //newPos.y += (0 - newPos.y) * .12f;

            newPos.y = 0.2f * Mathf.Sin(col * (Time.frameCount * 0.02f)); //  Magnitude versus Amplitude
            if (IsJitter) newPos.y += Random.Range(-0.02f, 0.02f);
            
            Verts.Add(newPos);
        }

        mesh.SetVertices(Verts);
        mesh.RecalculateNormals();
    }
}
