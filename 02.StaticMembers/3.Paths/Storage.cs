using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using _1_Point3D;

namespace _3.Paths
{
    public static class Storage
    {
        public static void SavePath(string inPath, params Path3D[] paths)
        {
            FileStream outFileStream = null;
            try
            {
                outFileStream = new FileStream(inPath, FileMode.Create);
                StreamWriter sw = new StreamWriter(outFileStream);
                using (sw)
                {
                    foreach (var path in paths)
                    {
                        sw.Write(path);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error! File not created!");
            }
            finally
            {
                if (outFileStream != null)
                {
                    outFileStream.Dispose();
                }
            }
        }

        public static Path3D LoadPathsFromFile(string inputPath)
        {
            Path3D path;
            List<Point3D> points = new List<Point3D>();
            try
            {
                StreamReader sr = new StreamReader(inputPath);
                using(sr)
                {
                    string line = sr.ReadLine();
                    while(line!=null)
                    {
                        string sub = line.Substring(0, 1);
                        if(sub == "x")
                        {
                            double[] pathPoints = getPathPoints(line);
                            Point3D point = new Point3D(pathPoints[0], pathPoints[1], pathPoints[2]);
                            points.Add(point);
                            line = sr.ReadLine();
                        }
                        else
                        {
                            line = sr.ReadLine();
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("No read file!");
            }
            path = new Path3D(points);
            return path;
        }

        public static double[] getPathPoints(string point)
        {
            double[] points = new double[3];
            int index = 0;
            Match match = Regex.Match(point, @"\d+\.*\d*");
            while (match.Success)
            {
                points[index++] = double.Parse(match.Value);
                match = match.NextMatch();
            }
            return points;
        }      
    }
}
