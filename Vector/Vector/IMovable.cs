﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework
{
    interface IMovable
    {
        void Move(Vector2 distance);
        void MoveTo(Vector2 newCenter);
    }
}
