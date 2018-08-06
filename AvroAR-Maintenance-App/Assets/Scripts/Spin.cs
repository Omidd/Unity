using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class Spin : MonoBehaviour {
	[Tooltip("Spin: Yes or No")]
	public bool spin;

	public float speed = 10f;


	public bool clockwise = true;

    [HideInInspector]
	public float direction = 1f;
    [HideInInspector]
    public float directionChangeSpeed = 2f;

    public enum Orientation { right, up, forward }

    public Orientation orientation;

    // Update is called once per frame
    void Update() {
		if (direction < 1f) {
			direction += Time.deltaTime / (directionChangeSpeed / 2);
		}

		if (spin) {
			if (clockwise) {
                if(orientation == Orientation.right)
					transform.Rotate(Vector3.right, (speed * direction) * Time.deltaTime);
                if (orientation == Orientation.up)
                    transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
                else {
                    transform.Rotate(Vector3.forward, (speed * direction) * Time.deltaTime);
                }
            } else {
                if (orientation == Orientation.right)
                    transform.Rotate(-Vector3.right, (speed * direction) * Time.deltaTime);
                if (orientation == Orientation.up)
                    transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
                else {
                    transform.Rotate(-Vector3.forward, (speed * direction) * Time.deltaTime);
                }
            }
		}
	}

    public void SpinToggle()
    {
        spin = !spin;
    }
}