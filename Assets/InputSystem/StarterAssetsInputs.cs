using UnityEngine;
using UnityEngine.InputSystem;

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool focus;
		public bool super_speed;

		[Header("Movement Settings")]
		public bool analogMovement;

#if !UNITY_IOS || !UNITY_ANDROID
		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;
#endif

		public void OnMove(InputValue value)
		{
			move = value.Get<Vector2>();
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				look = value.Get<Vector2>();
			}
		}

		public void OnJump(InputValue value)
		{
			jump = value.isPressed;
		}

		public void OnSprint(InputValue value)
		{
			sprint = value.isPressed;
		}

		public void OnFocus(InputValue value)
        {
			focus = value.isPressed;
        }


		public void OnSuperSpeed(InputValue value)
		{
			super_speed = value.isPressed;
		}

#if !UNITY_IOS || !UNITY_ANDROID

		private void OnApplicationFocus(bool hasFocus)
		{
			Cursor.lockState = cursorLocked ? CursorLockMode.Locked : CursorLockMode.None;
		}

#endif

	}
	
}