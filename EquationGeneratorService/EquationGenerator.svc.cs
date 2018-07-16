// ******************************************************************************************************************
//  EquationGenerator - a REST service that produces arithmetic equations
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

namespace EquationGeneratorService
{
    /// <summary>
    /// EquationGenerator Class - to create an arithmetic equation using random numbers.
    /// </summary>
    public class EquationGenerator : IEquationGenerator
    {
        /// <summary>
        /// GenerateEquation Method - to create an <c>Equation</c> object using a random number generator
        /// that has a min-max range based on the <paramref name="level"/> value.
        /// </summary>
        /// <param name="operation">string</param>
        /// <param name="level">string</param>
        /// <returns></returns>
        public Equation GenerateEquation(string operation, string level)
        {
            //Calculate maximum number to be saved
            int max = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(level)));
            //Calculate minimum number to be saved
            int min = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(level) - 1));

            //Generate random numbers
            Random random = new Random();

            //Create an equation using random numbers between the min-max range
            Equation equation = new Equation(random.Next(min, max), random.Next(min, max), operation);

            return equation;
        } // end method GenerateEquation
    } // end class EquationGenerator
} // end namespace EquationGeneratorService
