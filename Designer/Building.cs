using System;
using System.Collections.Generic;

namespace Kawnkreet
{
    class Building
    {
        public Building(InputData inputData)
        {
            internalData = new InputData(inputData);
        }
        public const int fy = 500;
        public const int concreteDensity = 2500;
        public int TotalPanelsFloor;
        public InputData internalData = null;
        public List<List<double[]>> SlabList = null;
        public List<Slab> FloorSlabCollection = null;
        public void DesignSlabs()
        {
            TotalPanelsFloor = CalcTotalPanels(internalData);
            CalcUniquePanels(internalData.GridX, internalData.GridY);
            //i think iterating slab objects is the best strategy
            FloorSlabCollection = new List<Slab>();
            
            for (int i = 0; i < UniquePanels; i++)
            {
                Slab newSlab = new Slab();
                newSlab.Design(internalData);
                FloorSlabCollection.Add(newSlab);
            }
        }
        private int CalcTotalPanels(InputData inputData)
        {
            return inputData.GridX * inputData.GridY;
        }

        public int UniquePanels;
        private void CalcUniquePanels(int GridX, int GridY)
        {
            if (GridY == 3)
            {
                if (GridX <= 4)
                {
                    UniquePanels = 4;
                }
                else if (GridX >= 6)
                {
                    UniquePanels = 6;
                }
            }
            else if (GridY > 3)
            {
                if (GridX > 4)
                {
                    UniquePanels = 9;
                }
            }
        }
        public class Slab
        {
            public Slab()
            {
            }
            public static int slab = 0;
            private double h;
            private double hDash;
            private double n;
            private double f;
            private double colDiam;
            private double[] k;
            private double[] zod;
            private double[] z;
            public double[] minSteel;
            private double[] asReq;
            private int[] diamBars = new int[] { 8, 10, 12, 16 };
            private double[] areaBars = new double[] { 50.24, 78.5, 113.04, 200.96};
            public double[] areaBar = new double[8];
            public double[] asProv = new double[8];
            public double[] barSpacing = new double[8];
            private int[] noBars = new int[8];
            private int[] length;
            private float volumes;
            private float mass;
            private float[] ee;
            private float[] ec;
            private int numTrucks;
            private double allowableRatio;
            private double actualRatio;
            private float maxShear;
            private int uniqueSlabs;
            private double[] barLength;
            public double[] MomentList = null;
            private double[] momentDirSlab = null;
            public List<double[]> SlabMomList;
            private double volSteel;
            private double massSteel;
            private double eeSteel;
            private double ecSteel;
            private double eeTransport;
            private double ecTransport;
            private double massConcrete;
            private double v;
            private double[] vc;
            private double u;
            private double vStress;
            private double vMax;

            private double modFactor;
            private double fs;

            public void Design(InputData internalData)
            {
                n = 1.35 * ( internalData.DeadLoad + internalData.PartitionLoad )+ 1.5 * internalData.ImpLoad;
                f = n * internalData.Ly * internalData.Lx;
                hDash = internalData.Ly * 1000 / 33;
                h = hDash + (internalData.Cover + diamBars[2] / 2);
                int colDiam = (int)Math.Sqrt(4 * (internalData.ColDim ^ 2) / Math.PI);
                CalcXYMoments(internalData);
            }
            
            public void CalcXYMoments(InputData internalData)
            {
                int xy = 0;
                int m=0;
                SlabMomList = new List<double[]>();
                double cStrip=0.0;
                double mStrip=0.0 ;
                for (xy = 0; xy < 2; xy++)
                {
                    double m1stHog = MomentFactors.mfAll[xy][slab][m++] * f * (xy % 2 == 0 ? internalData.Ly : internalData.Lx) + 0.15 * f * (colDiam / 1000);
                    double m2ndHog = MomentFactors.mfAll[xy][slab][m++] * f * (xy % 2 == 0 ? internalData.Ly : internalData.Lx) + 0.15 * f * (colDiam / 1000);
                    double mIntSpan = MomentFactors.mfAll[xy][slab][m++] * f * xy % 2 == 0 ? internalData.Ly : internalData.Lx;
                    cStrip = xy % 2 == 0 ? internalData.Lx : internalData.Ly / 2;
                    mStrip = xy % 2 == 0 ? internalData.Lx : internalData.Ly / 2;
                    double maxHogCol = MomentFactors.mfAll[xy][slab][m++] * m1stHog;
                    double maxHogMid = MomentFactors.mfAll[xy][slab][m++] * m1stHog;
                    double m2ndHogCol = MomentFactors.mfAll[xy][slab][m++] * m2ndHog;
                    double m2ndHogMid = MomentFactors.mfAll[xy][slab][m++] * m2ndHog;
                    double mIntCol = MomentFactors.mfAll[xy][slab][m++] * mIntSpan;
                    double mIntMid = MomentFactors.mfAll[xy][slab][m++] * mIntSpan;
                    m = 0;

                    momentDirSlab = new double[8];
                    momentDirSlab[0] = m1stHog * 2 / 3;
                    momentDirSlab[1] = m2ndHog * 1 / 3;
                    momentDirSlab[2] = maxHogMid;
                    momentDirSlab[3] = m2ndHogCol * 2 / 3;
                    momentDirSlab[4] = m2ndHogCol * 1 / 3;
                    momentDirSlab[5] = m2ndHogMid;
                    momentDirSlab[6] = mIntCol;
                    momentDirSlab[7] = mIntMid;
                    SlabMomList.Add(momentDirSlab);

                    k = new double[8];
                    zod = new double[8];
                    z = new double[8];
                    for (int i = 0; i < 8; i++)
                    {
                        if (momentDirSlab[i] != 0.0)
                        {
                            if (i == 2 || i == 5 || i == 7)
                            {
                                k[i] = Math.Pow(10, 6) * Math.Abs(momentDirSlab[i]) / (mStrip * 1000 * (hDash * hDash) * internalData.Fck);
                            }
                            else
                            {
                                k[i] = Math.Pow(10, 6) * Math.Abs(momentDirSlab[i]) / (cStrip * 1000 * (hDash * hDash) * internalData.Fck);
                            }
                            if (k[i] > 0.156)
                            {
                                k[i] = 0.156;
                            }
                            zod[i] = 0.5 + Math.Sqrt(0.25 - k[i] / 0.9);
                            if (zod[i] > 0.95)
                            {
                                zod[i] = 0.95;
                            }
                            z[i] = zod[i] * hDash;
                        }
                    }

                    minSteel = new double[2];
                    //minSteel[0] = 0.0013 * h * cStrip * 1000;
                    //minSteel[1] = 0.0013 * h * mStrip * 1000;
                    minSteel[0] = 0.0013  * h * 1000;
                    minSteel[1] = 0.0013  * h * 1000;

                    asReq = new double[8];
                    for (int i = 0; i < 8; i++)
                    {
                        asReq[i] = momentDirSlab[i] == 0.0 ? 0.0 : Math.Pow(10, 6) * Math.Abs(momentDirSlab[i]) / (0.87 * fy * z[i]);

                        if (i == 2 || i == 5 || i == 7)
                        {
                            if (asReq[i] < minSteel[1])
                            {
                                asReq[i] = minSteel[1];
                            }
                        }
                        else
                        {
                            if (asReq[i] < minSteel[0])
                            {
                                asReq[i] = minSteel[0];
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (asReq[i] != 0.0)
                        {
                            if (i == 2 || i == 5 || i == 7)
                            {
                                int addBar = 0;
                                int x = 2;
                                while (!(barSpacing[i] > 124) || !(barSpacing[i] < 350))
                                {
                                    noBars[i] = (int)(asReq[i] / areaBars[x]) + addBar;
                                    areaBar[i] = areaBars[x];
                                    asProv[i] = noBars[i] * areaBars[x];
                                    barSpacing[i] = 0.5 * mStrip * 1000 / noBars[i];
                                    barSpacing[i] = Math.Abs(barSpacing[i] / 25) * 25;

                                    if (barSpacing[i] >= 124 && barSpacing[i] <= 351)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        if (barSpacing[i] > 350)
                                        {
                                            addBar++;
                                        }
                                        else if (barSpacing[i] < 125)
                                        {
                                            if (x == 3)//at largest bar size, set back to standard h12
                                            {
                                                addBar++;       //maybe later add more detail to this to find trade off of steel area between h16/h14 ~~ area/spacing
                                            }
                                            else
                                            {
                                                x++;
                                            }
                                        }
                                    }
                                }
                            }
                            if(i == 3 || i == 0)    //check case i==0..
                            {
                                if (asReq[i] != 0.0)
                                {
                                    int addBar = 0;
                                    int x = 2;
                                    while (!(barSpacing[i] > 124) || !(barSpacing[i] < 350))
                                    {
                                        noBars[i] = (int)(asReq[i] / areaBars[x]) + addBar;
                                        areaBar[i] = areaBars[x];
                                        asProv[i] = noBars[i] * areaBars[x];
                                        barSpacing[i] = 0.5 * cStrip * 1000 / noBars[i];
                                        barSpacing[i] = Math.Abs(barSpacing[i] / 25) * 25;

                                        if (barSpacing[i] >= 124 && barSpacing[i] <= 351)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            if (barSpacing[i] > 350)
                                            {
                                                addBar++;
                                            }
                                            else if (barSpacing[i] < 125)
                                            {
                                                if (x == 0)//at smallest bar size, set back to standard h12
                                                {
                                                    addBar--;       //reduce number of bars
                                                }
                                                else
                                                {
                                                    x--;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (i == 1 || i == 4)
                            {
                                int addBar = 0;
                                int x = 2;
                                while (!(barSpacing[i] > 124) || !(barSpacing[i] < 350))
                                {
                                    noBars[i] = (int)(asReq[i] / areaBars[x]) + addBar;
                                    areaBar[i] = areaBars[x];
                                    asProv[i] = noBars[i] * areaBars[x];
                                    barSpacing[i] = 0.5 * cStrip * 1000 / noBars[i];
                                    barSpacing[i] = Math.Abs(barSpacing[i] / 25) * 25;

                                    if (barSpacing[i] >= 124 && barSpacing[i] <= 351)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        if (barSpacing[i] > 350)
                                        {
                                            addBar++;
                                        }
                                        else if (barSpacing[i] < 125)
                                        {
                                            if (x == 3)
                                            {
                                                addBar--;
                                            }
                                            else
                                            {
                                                x--;
                                            }
                                        }
                                    }
                                }
                            }
                            if (i == 6)
                            {
                                int addBar = 0;
                                int x = 2;
                                while (!(barSpacing[i] > 124) || !(barSpacing[i] < 350))
                                {
                                    noBars[i] = (int)(asReq[i] / areaBars[x]) + addBar;
                                    areaBar[i] = areaBars[x];
                                    asProv[i] = noBars[i] * areaBars[x];
                                    barSpacing[i] = 0.5 * cStrip * 1000 / noBars[i];
                                    barSpacing[i] = Math.Abs(barSpacing[i] / 25) * 25;

                                    if (barSpacing[i] >= 124 && barSpacing[i] <= 351)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        if (barSpacing[i] > 350)
                                        {
                                            addBar++;
                                        }
                                        else if (barSpacing[i] < 125)
                                        {
                                            if (x == 3)//at largest bar size, set back to standard h12
                                            {
                                                addBar--;
                                            }
                                            else
                                            {
                                                x--;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    barLength = new double[8];
                    barLength[0] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[1] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[2] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[3] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[4] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[5] = 0.45 * internalData.Ly * 1000 * internalData.ColDim;
                    barLength[6] = 0.8 * internalData.Ly * 1000;
                    barLength[7] = 0.8 * internalData.Ly * 1000;

                    //add vol of all bars in one slab
                    //collect each of these volumes in an array for each slab
                    double[] volBar = new double[8];
                    for (int i = 0; i < 8; i++)
                    {
                        volBar[i] = noBars[i] * areaBars[i] * barLength[i];
                    }
                    volSteel = volBar[0] + 2 * volBar[1] + volBar[2] + volBar[3] + 2 * volBar[4] + volBar[5] + volBar[6] + volBar[7];
                    massSteel = volSteel * 0.00000785;
                    eeSteel = massSteel * (0.365 + 8.1) * 1.15;
                    ecSteel = massSteel * (0.033 + 0.42) * 1.15;

                    numTrucks = (int)((h / (1000 * internalData.Lx * internalData.Ly)) + 1);
                    eeTransport = internalData.BatchSite * (11.04 + 8.42) * numTrucks;
                    ecTransport = internalData.BatchSite * numTrucks * 0.0064;

                    massConcrete = h / 1000 * internalData.Ly * internalData.Lx * concreteDensity;
                    double[] eeTotal = new double[5];

                    eeTotal[0] = internalData.PcCem * 6.15 * massConcrete * 1.0486;
                    eeTotal[1] = internalData.PcAgg * 0.124 * massConcrete * 1.0486;
                    eeTotal[2] = internalData.PcWater * 0.00814 * massConcrete * 1.0486;
                    eeTotal[3] = eeTransport;
                    eeTotal[4] = internalData.PcGGBS * 0.715 * massConcrete * 1.0486;

                    double[] ecTotal = new double[5];
                    ecTotal[0] = internalData.PcCem * 1.11 * massConcrete * 1.0486;
                    ecTotal[1] = internalData.PcAgg * 0.005 * massConcrete * 1.0486;
                    ecTotal[2] = internalData.PcWater * 0.00147 * massConcrete * 1.0486;
                    ecTotal[3] = numTrucks * ecTransport;
                    ecTotal[4] = internalData.PcGGBS * 0.029 * massConcrete * 1.486;

                    //place following checks before anything that is not interdependant!!!!!
                    int b = 7;
                    fs = 2 / 3 * fy * asReq[b] / asProv[b];
                    modFactor = 0.55 + (477 - fs) / momentDirSlab[b] / mStrip * (hDash * hDash);
                    allowableRatio = 0.9 * 33 * modFactor;
                    actualRatio = internalData.Ly / hDash;

                    if (actualRatio > allowableRatio)
                    {
                        h *= 1.1;
                        //restart calculations with increased depth!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    }

                    v = 1.15 * internalData.Ly * internalData.Lx * n;
                    vStress = v * 1000 / 4 * internalData.ColDim * hDash;
                    vMax = 0.8 * Math.Sqrt(internalData.Fck);

                    if (vStress > vMax)
                    {
                        h *= 1.05;
                        //restart!!!!!!!!!!!!!
                    }

                    //check shear at 1.5d from column face
                    u = 4 * (3 * hDash + internalData.ColDim);
                    v = 1.15 * n * (internalData.Ly * internalData.Lx - Math.Pow((u / 4 ),2));
                    vStress = v / (u * hDash);
                    vc = new double[8];
                    for (int i = 0; i < 8; i++)
                    { 
                        vc[i] = 0.79 * 100 * asProv[i] / Math.Pow((cStrip * hDash),1/3) * (Math.Pow((400 / hDash),1/4)*(Math.Pow((internalData.Fck / 25),1/4))) / (5/4);
                                //0.79 * ((100 * asProvd(i) / (cStrip * effDepth)) ^ (1 / 3)) * ((400 / effDepth) ^ 0.25) * ((fck / 25) ^ 1 / 3) / 1.25
                        if (vStress > vc[i])
                        {
                            asReq[i] *= 1.1 * asReq[i];
                            //go to restart calculations!!!!!!!!!!!!!!!!!!!!
                        }
                    }
                    slab++;
                }
            }

            //public void AdjustBarSpacing(int i, out int addBar, out int x)
            //{
            //    if (barSpacing[i] > 124 && barSpacing[i] < 351)
            //    {
            //        return;// continue;
            //    }
            //    else
            //    {
            //        if (barSpacing[i] > 350)
            //        {
            //            addBar++;
            //        }
            //        else if (barSpacing[i] < 125)
            //        {
            //            if (x == 3)
            //            {
            //                x = 0;
            //                addBar++;
            //            }
            //            else
            //            {
            //                x++;
            //            }
            //        }
            //    }
            //}
        }
        public static class MomentFactors
        {//y array
            static double[] mfY1 = new double[9] { 0.0, -0.086, 0.075, 0.0, 0.0, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfY2 = new double[9] { -0.086, -0.063, 0.071, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfY3 = new double[9] { 0.0, -0.063, 0.071, 0.0, 0.0, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfY4 = new double[9] { -0.086, -0.063, 0.071, 0.75, 0.25,0.75, 0.25, 0.55, 0.45 };
            static double[] mfY5 = new double[9] { 0.0, -0.063, 0.071, 0.0, 0.0, 0.75,0.25, 0.55, 0.45 };
            static double[] mfY6 = new double[9] { -0.086, -0.063, 0.071, 0.75, 0.25, 0.75, 0.25,0.55, 0.45 };
            static double[] mfY7 = new double[9] { -0.086,  -0.063, 0.071, 0.75, 0.25, 0.75, 0.25,0.55, 0.45 };
            static double[] mfY8 = new double[9] { -0.086, -0.063, 0.071, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfY9 = new double[9] { -0.086, -0.063, 0.071, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45};
            public static double[][] mfY = new double[][] { mfY1, mfY2, mfY3, mfY4, mfY5, mfY6, mfY7, mfY8, mfY9 };
            //x array
            static double[] mfX1 = new double[9] { 0.0, -0.086, 0.075,0.0, 0.0, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfX2 = new double[9] { 0.0, -0.063, 0.063, 0.0, 0.0, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfX3 = new double[9] { -0.086, -0.063, 0.063,0.75,0.25,  0.75,  0.25, 0.55, 0.45 };
            static double[] mfX4 = new double[9] { -0.086, -0.063, 0.063, 0.75, 0.25, 0.75, 0.25,0.55, 0.45 };
            static double[] mfX5 = new double[9] { -0.086, -0.086, 0.063, 0.75,0.25, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfX6 = new double[9] { -0.086, -0.063, 0.063, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfX7 = new double[9] {  -0.086, -0.063, 0.063, 0.75, 0.25, 0.75, 0.25,0.55, 0.45 };
            static double[] mfX8 = new double[9] { -0.086, -0.063,  0.063, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45 };
            static double[] mfX9 = new double[9] { -0.086, -0.063, 0.063, 0.75, 0.25, 0.75, 0.25, 0.55, 0.45 };
            public static double[][] mfX = new double[][] { mfX1, mfX2, mfX3, mfX4, mfX5, mfX6, mfX7, mfX8, mfX9 };

            public static double[][][] mfAll = new double[][][] { mfY, mfX};
        }
    }
}