﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{

    public interface ISlice
    {
        ISlice rotate(Direction direction);
    }

}
