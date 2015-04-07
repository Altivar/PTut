using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	
	private float rotationX = 0.0f;
	private float rotationY = 0.0f;
	
	public float lookSpeed = 5.0f;
	public float moveSpeed = 5.0f;
	public float YPosition = 1.0f;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		rotationX += Input.GetAxis("Mouse X")*lookSpeed;
		rotationY += Input.GetAxis("Mouse Y")*lookSpeed;
		
		while(rotationX > 180.0f)
			rotationX -= 360.0f;
		while(rotationX < -180.0f)
			rotationX += 360.0f;
		while(rotationY > 85.0f)
			rotationY = 85.0f;
		while(rotationY < -85.0f)
			rotationY = -85.0f;
		
		
		/*transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
		transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);
		
		
		///[Keyboard Gesture]///
		if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate( new Vector3(0,0, moveSpeed * Time.deltaTime), Space.Self);
		}
		else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate( new Vector3(0,0, -moveSpeed * Time.deltaTime), Space.Self);
		}
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate( new Vector3(moveSpeed * Time.deltaTime, 0, 0), Space.Self);
		}
		else if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate( new Vector3(-moveSpeed * Time.deltaTime, 0, 0), Space.Self);
		}
		///[Keyboard Gesture]///
		
		// reset the y value
		this.transform.position = new Vector3(this.transform.position.x, YPosition, this.transform.position.z);*/


		transform.Rotate(Vector3.up, 25.0f*Time.deltaTime, Space.World);
		
	}
}
