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
using System.Runtime.Serialization;

namespace EquationGeneratorService
{
    /// <summary>
    /// Equation Class - to represent an algebraic equation
    /// </summary>
    [DataContract]
    public class Equation
    {
        //Class Properties:
        [DataMember]
        private int Left { get; set; } // left operand
        [DataMember]
        private int Right { get; set; } // right operand
        [DataMember]
        private int Result { get; set; } // calculated result
        [DataMember]
        private string Operation { get; set; } // equation operation
        [DataMember]
        private string LeftHandSide
        {
            get { return ($"{Left} {Operation} {Right}"); }
            set { }
        } // end property LeftHandSide
        [DataMember]
        private string RightHandSide
        {
            get { return Result.ToString(); }
            set { }
        } // end property RightHandSide

        /// <summary>
        /// Default Constructor - to init data members to default values: Left = 0, Right = 0, Operation = "add"
        /// </summary>
        public Equation()
            : this(0, 0, "add")
        {

        } // end default constructor

        /// <summary>
        /// Three-arg Constructor - to init data members to given values
        /// </summary>
        /// <param name="leftValue">left operand as an int</param>
        /// <param name="rightValue">right operand as an int</param>
        /// <param name="type">operation as a string</param>
        public Equation(int leftValue, int rightValue, string type)
        {
            Left = leftValue;
            Right = rightValue;

            switch (type)
            {
                case "add":
                    Result = Left + Right;
                    Operation = "+";
                    break;
                case "subtract":
                    Result = Left - Right;
                    Operation = "-";
                    break;
                case "multiply":
                    Result = Left * Right;
                    Operation = "*";
                    break;
            } // end switch
        } // end three-arg constructor

        /// <summary>
        /// ToString - to override the ToString method and return the string representation of an Equation object
        /// </summary>
        /// <returns>Equation object as a string</returns>
        public override string ToString()
        {
            return ($"{Left} {Operation} {Right} = {Result}");
        } // end method ToString
    } // end class Equation
} // end namespace EquationGeneratorService