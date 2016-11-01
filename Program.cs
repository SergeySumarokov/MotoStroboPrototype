using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoStroboPrototype
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    public class Lamp
    {
        public Boolean IsOn;
        public Label VisualizationObject;
        public System.Drawing.Color LightColor;

        public Lamp(Label visualizationObject, System.Drawing.Color lightColor)
        {
            VisualizationObject = visualizationObject;
            LightColor = lightColor;
            TurnOff();
        }

        public void TurnOn()
        {
            IsOn = true;
            VisualizationObject.BackColor = LightColor;
        }

        public void TurnOff()
        {
            IsOn = false;
            VisualizationObject.BackColor = System.Drawing.Color.Black;
        }
    }
}
