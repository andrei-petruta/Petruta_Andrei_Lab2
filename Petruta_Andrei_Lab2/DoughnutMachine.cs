using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Petruta_Andrei_Lab2
{
    class DoughnutMachine : Component
    {
        public delegate void DoughnutCompleteDelegate();
        public event DoughnutCompleteDelegate DoughnutComplete;


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




        System.Windows.Threading.DispatcherTimer doughnutTimer; // AICI CEVA NU E BINE

        private void InitializeComponent()
        {
            this.doughnutTimer = new DispatcherTimer();

            this.doughnutTimer.Tick += new System.EventHandler(this.doughnutTimer_Tick);
        }

        
        


        public DoughnutMachine()
        {
            InitializeComponent();
        }


        private void doughnutTimer_Tick(object sender, EventArgs e)
        {
            Doughnut aDoughnut = new Doughnut(this.Flavor);
            mDoughnuts.Add(aDoughnut);
            DoughnutComplete();
        }


        public bool Enabled
        {
            set
            {
                doughnutTimer.IsEnabled = value;
            }
        }
        public int Interval
        {
            set
            {
                doughnutTimer.Interval = new TimeSpan(0, 0, value);
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
