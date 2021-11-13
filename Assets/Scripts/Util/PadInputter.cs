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

    public class PadInputter
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

        public static Vector2 RightStick()
        {
            var horizontal = Input.GetAxis("Horizontal2");
            var vertical = Input.GetAxis("Vertical2");
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 LeftStick()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 RightStickRaw()
        {
            var horizontal = Input.GetAxisRaw("Horizontal2");
            var vertical = Input.GetAxisRaw("Vertical2");
            return new Vector2(horizontal, vertical);
        }

        public static Vector2 LeftStickRaw()
        {
            var horizontal = Input.GetAxisRaw("Horizontal");
            var vertical = Input.GetAxisRaw("Vertical");
            return new Vector2(horizontal, vertical);
        }

        public static bool CheckInput(PadCode code, InputType type)
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