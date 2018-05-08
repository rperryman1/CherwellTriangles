using System;
using CherTriangles.Models;
using System.Web.Http;

namespace CherTriangles.Controllers
{
    public class TrianglesController : ApiController
    {

        public TriangleCoordinates GetCoordinates(string row, int column)
        {
            TriangleCoordinates coord = null;
            try
            {
                if (column < 1 || column > 12)
                    throw new Exception("Invalid Column Entry");

                int rowMult = 0;
                switch (row)
                {
                    case "A":
                        rowMult = 1;
                        break;
                    case "B":
                        rowMult = 2;
                        break;
                    case "C":
                        rowMult = 3;
                        break;
                    case "D":
                        rowMult = 4;
                        break;
                    case "E":
                        rowMult = 5;
                        break;
                    case "F":
                        rowMult = 6;
                        break;
                    default:
                        throw new Exception("Invalid Row Entry");
                }

                coord = new TriangleCoordinates();

                if (column % 2 == 0)
                {
                    coord.V1x = (column / 2) * 10;
                    coord.V1y = ((rowMult) * 10) - 10;
                    coord.V2x = coord.V1x - 10;
                    coord.V2y = coord.V1y;
                    coord.V3x = coord.V1x;
                    coord.V3y = coord.V1y + 10;
                }
                else
                {
                    coord.V1x = (column / 2) * 10;
                    coord.V1y = (rowMult) * 10;
                    coord.V2x = coord.V1x;
                    coord.V2y = coord.V1y - 10;
                    coord.V3x = coord.V1x + 10;
                    coord.V3y = coord.V1y;
                }
                return coord;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetTriangleByCoords(int V1x, int V1y, int V2x, int V2y, int V3x, int V3y)
        {
            try
            {
                double column = 0;
                var rowMult = 0;

                if (V2x == V1x)
                {
                    column = ((V1x / 10) * 2)+1;
                    rowMult = V1y / 10;
                }
                else
                {
                    column = (V1x / 10) * 2;
                    rowMult = (V1y + 10) / 10;
                }

                string row = "";

                switch (rowMult)
                {
                    case 1:
                        row = "A";
                        break;
                    case 2:
                        row = "B";
                        break;
                    case 3:
                        row = "C";
                        break;
                    case 4:
                        row = "D";
                        break;
                    case 5:
                        row = "E";
                        break;
                    case 6:
                        row = "F";
                        break;
                }

                return row + column;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}