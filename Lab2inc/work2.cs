using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2inc
{
    public enum EngineType {Gas, Disel, Electro};
    public enum Privod {Front, Back, Full}
    public enum Color {White, Silver, Black, Green, Red, Blue, Purple, Yellow}
    public class Car
    {
        public Car() { }
        public Car(string Firm_, string Model_, string Info_, int Year_, float Enginee_v, int mileage, bool mech, bool rwheel, EngineType type_e, Privod priv, Color colr)
        {
            Firm = Firm_; Model = Model_; Info = Info_; Year = Year_; EngineV = Enginee_v;
            milecage = mileage; Mechanical = mech; RightWHeel = rwheel; Engine = type_e;
            Wheel_Drive = priv; car_color = colr;
        }

        public string Firm, Model, Info;
        public int Year;
        public float EngineV = 3.0f;
        public int milecage = 0;
        public bool Mechanical = true;
        public bool RightWHeel = false;
        public EngineType Engine;
        public Privod Wheel_Drive;
        public Color car_color;
    }
    public partial class work2 : Form
    {
        public work2()
        {
            InitializeComponent();
        }
    }

}
