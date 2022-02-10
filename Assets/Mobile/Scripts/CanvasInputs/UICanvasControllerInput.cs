using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public StarterAssetsInputs starterAssetsInputs;

        public void VirtualMoveInput(Vector2 state)
        {
            starterAssetsInputs.move = state;
        }

        public void VirtualLookInput(Vector2 state)
        {
            starterAssetsInputs.look = state;
        }

        public void VirtualJumpInput(bool state)
        {
            starterAssetsInputs.jump = state;
        }

        public void VirtualSprintInput(bool state)
        {
            starterAssetsInputs.sprint = state;
        }

        public void VirtualFocusInput(bool state)
        {
            starterAssetsInputs.focus = state;
        }

        public void VirtualSuperSpeedInput(bool state)
        {
            starterAssetsInputs.super_speed = state;
        }
    }

}
