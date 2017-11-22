using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = -3.0F;
	private Vector3 moveDirection = Vector3.zero;
	public float rotateSpeed = 3.0F;

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			//var rotate = new Vector3(
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		
		}

		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
		else if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}