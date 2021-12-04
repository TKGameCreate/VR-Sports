using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputter
{
    public static class JyroInputter
    {
        public static Quaternion Jyro()
        {
            EnableJyro(true);
            return Input.gyro.attitude;
        }

        public static Vector3 JyroEuler()
        {
            EnableJyro(true);
            return Input.gyro.attitude.eulerAngles;
        }

        private static void EnableJyro(bool enable)
        {
            if (Input.gyro.enabled == enable) return;
            Input.gyro.enabled = enable;
        }
    }
}