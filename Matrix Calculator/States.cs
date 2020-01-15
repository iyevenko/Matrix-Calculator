using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Calculator
{
    public enum States
    {
        SELECT,     // select matrix to perform operation (press operation next)
        STORE,      // store currently shown matrix (press storage key next; ie A,B,C,D,E)
        OPERATION,   // once first matrix is selected, operation has been pressed (press second matrix next)
        ADD,
        SUBTRACT,
        MULTIPLY
    };
}
