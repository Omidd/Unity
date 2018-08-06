using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidBuilder : MonoBehaviour {


    GameObject Pyramid;

    public Material material; // material to be assigned in unity

    List<Vector3> verts = new List<Vector3>();  // verticies
    List<int> tris = new List<int>();  // connection order for verticies
    List<Vector2> uvs = new List<Vector2>(); // uv texture coordinates

	void Start () {

        Pyramid = new GameObject();

        Pyramid.AddComponent<MeshFilter>(); // needs a mesh, give it
        Pyramid.AddComponent<MeshRenderer>(); // meeds a Material
        
        Pyramid.GetComponent<MeshRenderer>().material = material; // assigned the material 

        BulidPyramid();

    }
	
	// Update is called once per frame
	void Update () {

        Pyramid.transform.Rotate(0,0.5f,0);
	}

    void BulidPyramid()
    {
        // face 1
        // -----------------------------
        verts.Add(new Vector3(0, 0, 0)); // 3 points
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(2, 0, 0));

        tris.Add(0);  // clockwise direction 
        tris.Add(1);
        tris.Add(2);

        uvs.Add(new Vector2(0,1));  // uv map for "only" one face to render
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));

        // face 2
        // -----------------------------
        verts.Add(new Vector3(2, 0, 0)); // first point = last point
        verts.Add(new Vector3(1, 2, 1)); // central is always here
        verts.Add(new Vector3(2, 0, 2)); //

        tris.Add(3);  // clockwise direction 
        tris.Add(4);
        tris.Add(5);

        uvs.Add(new Vector2(0, 1));  // uv map for "only" one face to render
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));
        // face 3
        // -----------------------------
        verts.Add(new Vector3(2, 0, 2)); 
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(0, 0, 2));  // last point = first point

        tris.Add(6);  // clockwise direction 
        tris.Add(7);
        tris.Add(8);

        uvs.Add(new Vector2(0, 1));  // uv map for "only" one face to render
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));
        // face 4
        // -----------------------------
        verts.Add(new Vector3(0, 0, 2));
        verts.Add(new Vector3(1, 2, 1));
        verts.Add(new Vector3(0, 0, 0));  // last point = first point

        tris.Add(9);  // clockwise direction 
        tris.Add(10);
        tris.Add(11);

        uvs.Add(new Vector2(0, 1));  // uv map for "only" one face to render
        uvs.Add(new Vector2(0.5f, 0));
        uvs.Add(new Vector2(1, 1));
        

        for (int i = 0; i< verts.Count; i++ )
        {
            Vector3 shift = verts[i];
            shift.x -= 1.0f;
            shift.z -= 1.0f;
            verts[i] = shift;
        }

        Mesh mesh = new Mesh();

        mesh.SetVertices(verts); // list assigned to a list 
        mesh.triangles = tris.ToArray(); // list assigned to an array 
        mesh.uv = uvs.ToArray();

        Pyramid.GetComponent<MeshFilter>().mesh = mesh;

        Pyramid.transform.localScale = new Vector3(1.3f, 1.0f, 1.3f);
        Pyramid.transform.Translate(0,1,0);

    }
}
