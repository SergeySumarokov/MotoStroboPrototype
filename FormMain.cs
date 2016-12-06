using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoStroboPrototype
{
    public partial class FormMain : Form
    {

        string LampLeftState;
        string LampRightState;
        string LampIndicatorState;
        Int32 StatePos;
        bool PowerIsOn;
        bool ModeButtonIsDown;
        Int32 Mode;
        Int32 ModeTimer;
        Lamp LampLeft;
        Lamp LampRight;
        Lamp LampIndicator;

        public FormMain()
        {
            InitializeComponent();
            Mode = 1;
            ModeTimer = 0;
            LampLeftState =      "00010001000100011111111111111111";
            LampRightState =     "11111111111111110001000100010001";
            LampIndicatorState = "00000000000000001111000011110000";
            this.BackColor = System.Drawing.Color.Black;
            LampLeft = new Lamp(HeadlightLeft, System.Drawing.Color.White);
            LampRight = new Lamp(HeadlightRight, System.Drawing.Color.White);
            LampIndicator = new Lamp(IndicatorLight, System.Drawing.Color.Red);
            Timer.Interval = 25;
            PowerIsOn = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelPower_Click(object sender, EventArgs e)
        {
            SwitchPower();
        }

        private void SwitchPower()
        {
            PowerIsOn = !PowerIsOn;
            if (PowerIsOn)
            {
                LampLeft.TurnOn();
                LampRight.TurnOn();
                LampIndicator.TurnOff();
                Mode = 1;
            }
            else
            {
                Timer.Stop();
                LampLeft.TurnOff();
                LampRight.TurnOff();
                LampIndicator.TurnOff();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (PowerIsOn &&  Mode == 1)
            {
                ModeTimer = 16;
                SwitchMode();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (PowerIsOn && ModeTimer == 0)
            {
                SwitchMode();
            }
        }

        private void SwitchMode()
        {
            if (Mode == 1)
            {
                Mode = 2;
                StatePos = 1;
                Timer.Start();
            }
            else
            {
                Timer.Stop();
                Mode = 1;
                LampLeft.TurnOn();
                LampRight.TurnOn();
                LampIndicator.TurnOff();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            char leftState = LampLeftState[StatePos - 1];
            if (leftState == '0')
                { LampLeft.TurnOff(); }
            else
                { LampLeft.TurnOn(); }

            char rightState = LampRightState[StatePos - 1];
            if (rightState == '0')
                { LampRight.TurnOff(); }
            else
                {LampRight.TurnOn();}

            char indicatorState = LampIndicatorState[StatePos - 1];
            if (indicatorState == '0')
                { LampIndicator.TurnOff(); }
            else
                { LampIndicator.TurnOn(); }

            if (StatePos < LampLeftState.Length)
                { StatePos++; }
            else
                { StatePos = 1; }
            if (ModeTimer > 0)
                ModeTimer--;

        }

    }
}
