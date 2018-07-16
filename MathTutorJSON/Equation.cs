// ******************************************************************************************************************
//  Math Tutor - GUI application that randomly generates an arithmetic equation.
//  Program calls EquationGenerator REST service to randomly generate the equation.
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System;

namespace MathTutorJSON
{
    /// <summary>
    /// Equation Class - represents an equation object (POCO).
    /// </summary>
    [Serializable]
    class Equation
    {
        public int Left = 0;
        public int Right = 0;
        public int Result = 0;
        public string LeftHandSide = null;
        public string RightHandSide = null;
        public string Operation = null;
    } // end class Equation
} // end namespace MathTutorJSON
