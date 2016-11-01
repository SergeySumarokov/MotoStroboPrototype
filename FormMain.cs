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
            this.KeyPreview = true;
            LampLeftState =      "00010001000100111111111111111111";
            LampRightState =     "11111111111111110001000100010001";
            LampIndicatorState = "00000000111100001111000000000000";
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

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            throw new Exception();
            if (e.KeyCode == Keys.M)
            {
                ModeButtonIsDown = true;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                ModeButtonIsDown = false;
                throw new Exception();

            }
        }

        private void PowerSwitch_Click(object sender, EventArgs e)
        {
            PowerSwitchClick();
        }


        private void PowerSwitchClick()
        {
            PowerIsOn = !PowerIsOn;
            if (PowerIsOn)
            {
                LampLeft.TurnOn();
                LampRight.TurnOn();
                LampIndicator.TurnOn();
                Mode = 2;
                StatePos = 1;
            }
            else
            {
                LampLeft.TurnOff();
                LampRight.TurnOff();
                LampIndicator.TurnOff();
            }
            Timer.Enabled = PowerIsOn;
        }

        private void ModeSwitchDown()
        {
            if (ModeTimer == 0)
            {
                Mode = 2;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            ModeSwitch.Visible = ModeButtonIsDown;

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

        }
    }
}
