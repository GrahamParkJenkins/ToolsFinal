using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProcessor_GrahamPark_259907
{
    public class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float nX, float nY, float nZ)
        {
            x = nX;
            y = nY;
            z = nZ;
        }

        public Vector3()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }

        public void SetValues(float nX, float nY, float nZ)
        {
            x = nX;
            y = nY;
            z = nZ;
        }

        public float GetDistanceFrom(Vector3 other)
        {
            double dist = Math.Sqrt(Math.Pow(Math.Abs(other.x - x), 2) + Math.Pow(Math.Abs(other.y - y), 2) + Math.Pow(Math.Abs(other.z - z), 2));
            Console.WriteLine(dist);
            return (Convert.ToSingle(dist));
        }

    }
}
