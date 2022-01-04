using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputter
{
    public enum InputType
    {
        Down,
        Up,
        Hold
    }

    public static class PadInputter
    {
        private static Dictionary<PadCode, string> s_button = new Dictionary<PadCode, string>()
        {
            { PadCode.A, "A" },
            { PadCode.B, "B" },
            { PadCode.X, "X" },
            { PadCode.Y, "Y" },
            { PadCode.R1, "R1" },
            { PadCode.R2, "R2" },
            { PadCode.L1, "L1" },
            { PadCode.L2, "L2" },
            { PadCode.UpArrow, "UpArrow" },
            { PadCode.DownArrow, "DownArrow" },
            { PadCode.LeftArrow, "LeftArrow" },
            { PadCode.RightArrow, "RightArrow" }
        };
        private const string RIGHT_HORIZONTAL = "Horizontal2";
        private const string RIGHT_VERTICAL = "Vertical2";
        private const string LEFT_HORIZONTAL = "Horizontal";
        private const string LEFT_VERTICAL = "Vertical";

        public static Vector2 RightStickAxis()
        {
            var horizontal = Input.GetAxis(RIGHT_HORIZONTAL);
            var vertical = Input.GetAxis(RIGHT_VERTICAL);
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 LeftStickAxis()
        {
            var horizontal = Input.GetAxis(LEFT_HORIZONTAL);
            var vertical = Input.GetAxis(LEFT_VERTICAL);
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 RightStickAxisRaw()
        {
            var horizontal = Input.GetAxisRaw(RIGHT_HORIZONTAL);
            var vertical = Input.GetAxisRaw(RIGHT_VERTICAL);
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 LeftStickAxisRaw()
        {
            var horizontal = Input.GetAxisRaw(LEFT_HORIZONTAL);
            var vertical = Input.GetAxisRaw(LEFT_VERTICAL);
            return new Vector2(horizontal, vertical);
        }

        public static bool CheckInputButton(PadCode code, InputType type)
        {
            string name;
            var success = s_button.TryGetValue(code, out name);
            if (!success)
            {
                return false;
            }

            switch (type)
            {
                case InputType.Up:
                    return Input.GetButtonUp(name);
                case InputType.Down:
                    return Input.GetButtonDown(name);
                case InputType.Hold:
                    return Input.GetButton(name);
                default:
                    return false;
            }
        }
    }
}