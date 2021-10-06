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
        vector speed, limits;
        
        public Ball(float W = 0, float H = 0, float spx = 0, float spy = 0, int r = 5)
        {
            posAct = new vector (W/2, H/2);
            speed = new vector (spx, spy);
            limits = new vector (W, H);
            radio = r;
        }

        public void Move()
        {
            posAct += speed;
            Bounce();
        }

        public void Bounce()
        {
            if ((posAct.x+radio) >= limits.x || (posAct.x-radio) < 0) speed.x = -speed.x;
            if ((posAct.y+radio) >= limits.y || (posAct.y-radio) < 0) speed.y = -speed.y;
        }

    }
}
