using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Ball
    {
        public vector posAct;
        public int radio;
        float lim;
        Random ran;
        vector speed, limits, aceleracion;
        
        public Ball(float W = 0, float H = 0, float spx = 0, float spy = 0, float acelx = 0, float acely = 0, int r = 5, float lim = -1)
        {
            posAct = new vector (W/2, H/2);
            speed = new vector (spx, spy);
            aceleracion = new vector (acelx, acely);
            limits = new vector (W, H);
            this.lim = lim;
            ran = new Random();
            radio = r;
        }

        public void Move()
        {
            float x = (float)ran.NextDouble();
            float y = (float)ran.NextDouble();
            if (ran.Next(10) < 5) x = -x;
            if (ran.Next(10) < 5) y = -y;
            aceleracion = new vector(x, y);
            posAct += speed;
            speed += aceleracion;
            if(lim != -1)
                speed.Limitar(lim);
            Edge();
        }

        public void Edge()
        {
            if(posAct.x > limits.x)posAct.x = 0;
            if(posAct.y > limits.y)posAct.y = 0;
            if(posAct.x < 0)posAct.x = limits.x;
            if(posAct.y < 0)posAct.y = limits.y;
        }

    }
}
