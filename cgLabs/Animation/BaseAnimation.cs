using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cgLabs.Animation
{
    public class BaseAnimation
    {
        
        public uint[] Sequence { get; set; }
        public BaseAnimation(uint[] sequence)
        {
            this.Sequence = sequence;
        }
        public void Play( Action moveX, Action moveY, Action rotateX, Action rotateY, Action scale, Action bigScale, Action rotateZ)
        {
            for(int i = 0; i < Sequence.Length; i++)
            {
                switch (Sequence[i])
                {
                    case 1:
                        moveX();
                        break;
                    case 2:
                        moveY();
                        break;
                    case 3:
                        rotateX();
                        break;
                    case 4:
                        rotateY();
                        break;
                    case 5:
                        scale();
                        break;
                    case 6:
                        bigScale();
                        break;
                    case 7:
                        rotateZ();
                        break;
                }
                
            }
        }
    }
}
