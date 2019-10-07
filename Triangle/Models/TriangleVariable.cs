using System;

namespace Triangle.Models {
    public class TriangleVariable
    {
    public int SideOne { get; set;}
    public int SideTwo { get; set;}
    public int SideThree { get; set;}
    public string Type {get; set;}
    
    public TriangleVariable(int sideOne, int sideTwo , int sideThree) 
    {
        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;
        Type = DetermineType();
    }

    private string DetermineType()
    {
        string triangleType = "";
        int maxSide = Math.Max(Math.Max(SideOne,SideTwo),SideThree);
        int sumSides = SideOne + SideTwo + SideThree;
        int sum2Smallest = sumSides - maxSide;
        if(maxSide > sum2Smallest){
            triangleType = "not a triangle";
        } else{
            triangleType = MatchingTriangleSides();
        }
        return triangleType;
    }

        public string MatchingTriangleSides() 
        {
            if (SideOne == SideTwo && SideTwo == SideThree) {
                return "Equilateral Triangle";
            } else if ((SideOne != SideTwo && SideTwo != SideThree) && SideThree != SideOne) {
            return "Scalene Triangle";
            } else {
            return "Isoceles";
            }
        }
    }
}