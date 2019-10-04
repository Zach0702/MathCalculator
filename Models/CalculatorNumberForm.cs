using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsPractice.Models
{
    public class CalculatorNumberForm
    {
        //public int NumberOne { get; set; }
        //public int NumberTwo { get; set; }
        
        public string MathOperator { get; set; }
        public double NumberOne { get ; set ; }
        public double NumberTwo { get; set ; }
        public double Total { get; set; }

        public string[] MathOperators = new[] { "+", "-", "*","/" };
    }



    //public string AdditionOperator { get; set; }
    //public string SubtractionOperator { get; set; }
    //public string MultiplicationOperator { get; set; }
    //public string DivisionOperator { get; set; }

    //public CalculatorNumberForm()
    //{
    //    AdditionOperator = "+";
    //    SubtractionOperator = "-";
    //    MultiplicationOperator = "*";
    //    DivisionOperator = "/";
    //}

}

