using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNuGetPackageCSharp
{
    public class CircleCalculator
    {
        public double RadiusCalculator(double radius)
        {
            double pi = 3.14;
            double reply = 0;
            //the area of the circle = pi * (radius * radius )

            if (radius != null && radius > 0)
            {
                reply = (radius * radius) * pi;
            }

            return reply;
        }

        public double TriangleCalculator(double radius)
        {
            double pi = 3.14;
            double reply = 0;
            //the area of the circle for triangle method = 1/2 (2 pi radius * radius )
            //2 pi radius = base of triangle
            //radius = height of triangle



            double baseTriangle = 2 * pi * radius;

            //To understand that a triangle is a right triangle, we need to know the lengths of all its sides.
            //bunun üçün əlimizdə olan üçbucağın döşəməsini ikiyə bölüb digər tərəfdən radiusunu hesablayırıq ki, düz üçbucaq alınsın.
            //Calculate : 

            double x = radius;
            double y = baseTriangle / 2;
            double z = ((y * y) - (x * x));

            if (z * 2 == baseTriangle * baseTriangle)
            {
                throw new Exception("this triangle is right angled");
            }



            if (radius != null && radius > 0)
            {
                reply = (baseTriangle * radius) / 2;
            }

            return reply;
        }

    }
}
