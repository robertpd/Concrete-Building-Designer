using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kawnkreet
{
    public class InputData
    {
        public InputData()
        { 
        }
        public InputData(InputData src)
        {
            GridX = src.GridX;
            GridY = src.GridY;
            Ly = src.Ly;
            Lx = src.Lx;
            NumStories = src.NumStories;
            FloorToFloorHeight = src.FloorToFloorHeight;
            ColDim = src.ColDim;
            ImpLoad = src.ImpLoad;
            DeadLoad = src.DeadLoad;
            PartitionLoad = src.PartitionLoad;
            BatchSite = src.BatchSite;
            GGBSBatch = src.GGBSBatch;
            Cover = src.Cover;
            ConcreteGrade = src.ConcreteGrade;
            Fck = src.Fck;
            PcAgg = src.PcAgg;
            PcCem = src.PcCem;
            PcWater = src.PcWater;
            PcGGBS = src.PcGGBS;
            ConcretePrice = src.ConcretePrice;
            SteelPrice = src.SteelPrice;
        }
        public int GridX
        {
            get { return m_GridX; }
            set { m_GridX = value; }
        }
        private int m_GridX;        
        public int GridY
        {
            get { return m_GridY; }
            set { m_GridY = value; }
       }
        private int m_GridY;
        private double m_Ly;
        public double Ly
        {
            get { return m_Ly; }
            set { m_Ly = value; }
        }
        private double m_Lx;
        public double Lx
        {
            get { return m_Lx; }
            set { m_Lx = value; }
        }
        private int m_NumStories;
        public int NumStories
        {
            get { return m_NumStories; }
            set { m_NumStories = value; }
        }
        private int m_FloorToFloorHeight;
        public int FloorToFloorHeight
        {
            get { return m_FloorToFloorHeight; }
            set { m_FloorToFloorHeight = value; }
        }
        private int m_ColDim;
        public int ColDim
        {
            get { return m_ColDim; }
            set { m_ColDim = value; }
        }
        private double m_ImpLoad;
        public double ImpLoad
        {
            get { return m_ImpLoad; }
            set { m_ImpLoad = value; }
        }
        private double m_DeadLoad;
        public double DeadLoad
        {
            get { return m_DeadLoad; }
            set { m_DeadLoad = value; }
        }
        private int m_PartitionLoad;
        public int PartitionLoad
        {
            get { return m_PartitionLoad; }
            set { m_PartitionLoad = value; }
        }
        private int m_BatchSite;
        public int BatchSite
        {
            get { return m_BatchSite; }
            set { m_BatchSite = value; }
        }
        private int m_GGBSBatch;
        public int GGBSBatch
        {
            get { return m_GGBSBatch; }
            set { m_GGBSBatch = value; }
        }
        private int m_Cover;
        public int Cover
        {
            get { return m_Cover; }
            set { m_Cover = value; }
        }
        private int m_ConcreteGrade;
        public int ConcreteGrade
        {
            get { return m_ConcreteGrade; }
            set { m_ConcreteGrade = value; }
        }
        private int m_Fck;
        public int Fck
        {
            get { return m_Fck; }
            set { m_Fck = value; }
        }
        private int m_PcWater;
        public int PcWater
        {
            get { return m_PcWater; }
            set { m_PcWater = value; }
        }
        private int m_PcAgg;
        public int PcAgg
        {
            get { return m_PcAgg; }
            set { m_PcAgg = value; }
        }
        private int m_PcGGBS;
        public int PcGGBS
        {
            get { return m_PcGGBS; }
            set { m_PcGGBS = value; }
        }
        private int m_PcCem;
        public int PcCem
        {
            get { return m_PcCem; }
            set { m_PcCem = value; }
        }
        private int m_ConcretePrice;
        public int ConcretePrice
        {
            get { return m_ConcretePrice; }
            set { m_ConcretePrice = value; }
        }
        private int m_SteelPrice;
        public int SteelPrice
        {
            get { return m_SteelPrice; }
            set { m_SteelPrice = value; }
        }
        private int m_SlabDepth;
        public int SlabDepth
        {
            get { return m_SlabDepth; }
            set { m_SlabDepth = value; }
        }
        private int m_ThermalMass;
        public int ThermalMass
        {
            get { return m_ThermalMass; }
            set { m_ThermalMass = value; }
        }
        private int m_MaterialCost;
        public int MaterialCost
        {
            get { return m_MaterialCost; }
            set { m_MaterialCost = value; }
        }
    }
}
