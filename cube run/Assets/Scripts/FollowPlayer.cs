using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;

	private void Update()
	{
		transform.position = player.position+offset;
	}
}
