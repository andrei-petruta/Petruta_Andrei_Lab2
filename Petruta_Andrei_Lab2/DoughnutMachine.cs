using System;
using System.Collections.Generic;
using System.Text;

namespace Petruta_Andrei_Lab2
{
    class DoughnutMachine : Component
    {

        private DoughnutType mFlavor;

        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }

            set
            {
                mFlavor = value;
            }
        }


        private System.Collections.ArrayList mDoughnuts = new System.Collections.ArrayList();
        public Doughnut this[int Index]
        {
            get
            {
                return (Doughnut)mDoughnuts[Index];
            }

            set
            {
                mDoughnuts[Index] = value;
            }
        }
    }

    public enum DoughnutType
    {
        Glazed,
        Sugar,
        Lemon,
        Chocolate,
        Vanilla
    }

    class Doughnut
    {
        private DoughnutType mFlavor;
        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }

            set
            {
                mFlavor = value;
            }
        }


        private float mPrice = .50F;
        public float Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }



        private readonly DateTime mTimeOfCreation;
        public DateTime TimeOfCreation
        {
            get
            {
                return mTimeOfCreation;
            }
        }




        public Doughnut(DoughnutType aFlavor) //constructor 
        {
            mTimeOfCreation = DateTime.Now;
            mFlavor = aFlavor;
        }
    }


        




}
