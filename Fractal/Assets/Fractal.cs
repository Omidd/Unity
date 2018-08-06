using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour {

    public Mesh[] meshes;   // assigned in editor
    public Material material;
    public int maxDepth;
    public float childScale;
    int depth;

    // to fix materials per depth
    private Material[,] materials;

    public float maxRotationSpeed;
    public float maxTwist;

    private float rotationSpeed;


    private void Start()
    {
        rotationSpeed = Random.Range(-maxRotationSpeed, maxRotationSpeed);
        transform.Rotate(Random.Range(-maxTwist, maxTwist), 0f, 0f);

        if (materials == null) {
            initializeMaterials();  // creates materials[i]
        }
        gameObject.AddComponent<MeshFilter>().mesh = meshes[Random.Range(0, meshes.Length)];
        gameObject.AddComponent<MeshRenderer>().material = materials[depth, Random.Range(0,2)];
        //GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.white, Color.black, (float)depth/ maxDepth);
        // new GameObject("Fractal Child").AddComponent<Fractal>();
        if ( depth < maxDepth)
        {
            StartCoroutine(createChilderen());
        }
    }

    private void Update()
    {
        transform.Rotate(0f, 30f * Time.deltaTime, 0f);
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    private void initializeMaterials()
    {
        materials = new Material[maxDepth + 1, 2];
        for (int i = 0; i <= maxDepth; i++) // 6 levels of material lerp
        {
            float t = i / (maxDepth - 1f);
            t *= t;
            materials[i, 0] = new Material(material);
            materials[i, 0].color = Color.Lerp(Color.white, Color.green, t);
            materials[i, 1] = new Material(material);
            materials[i, 1].color = Color.Lerp(Color.white, Color.red, t);
        }
        materials[maxDepth, 0].color = Color.blue;
        materials[maxDepth, 1].color = Color.magenta;
    }

    public float spawnProbability;

    private IEnumerator createChilderen()
    {

        for (int i = 0; i < childDirections.Length; i++)
        {
            if (Random.value < spawnProbability)
            {
                yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
                new GameObject("Fractl Child").AddComponent<Fractal>().Initialize(this, i);
            }
            //GetComponent<Fractal>().material.color = materials[i].color;
            //GetComponent<MeshRenderer>().material = materials[i];
        }
    }

    // Moving Direction and Orientation data into a static array
    private static Vector3[] childDirections = { Vector3.up, Vector3.right, Vector3.left, Vector3.forward, Vector3.back };
    private static Quaternion[] childOrientations = { Quaternion.identity, Quaternion.Euler(0f, 0f, -90f), Quaternion.Euler(0f, 0f, 90f), Quaternion.Euler(90f, 0f, 0f), Quaternion.Euler(-90f, 0f, 0f) };


    private void Initialize(Fractal parent, int childIndex)
    {
        meshes = parent.meshes;
        materials = parent.materials;
        maxDepth = parent.maxDepth;
        depth = parent.depth + 1;
        childScale = parent.childScale;
        spawnProbability = parent.spawnProbability;
        rotationSpeed = parent.rotationSpeed;
        maxTwist = parent.maxTwist;

        // parent-child relationship btw game objects is defined by their transform hierarchy
        transform.parent = parent.transform;

        transform.localScale = Vector3.one * childScale;
        transform.localPosition = childDirections[childIndex] * (0.5f + 0.5f * childScale);
        transform.localRotation = childOrientations[childIndex];
        //transform.GetComponent<MeshRenderer>().material.color = materials[childIndex].color;
    }

}
