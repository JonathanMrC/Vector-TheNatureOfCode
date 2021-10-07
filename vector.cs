using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class vector
    {
        public float x, y;
        public vector(float _x = 0, float _y = 0)
        {
            x = _x;
            y = _y;
        }

        public static vector operator +(vector a, vector b)
            => new vector(a.x + b.x, a.y + b.y);
        public static vector operator -(vector a, vector b)
            => new vector(a.x - b.x, a.y - b.y);
        public static vector operator *(vector a, float scalar)
            => new vector(a.x * scalar, a.y * scalar);
        public override string ToString() => "" + +this.x + " , " + this.y;

        public float Magnitud()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public void Normalizar()
        {
            float temp = Magnitud();
            x /= temp;
            y /= temp;
        }

        public void setMagnitud(float m)
        {
            Normalizar();
            x *= m;
            y *= m;
        }

        public void Limitar(float lim)
        {
            if (lim < Magnitud()) setMagnitud(lim);
        }
    }
}
