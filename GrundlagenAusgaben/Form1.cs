namespace GrundlagenAusgaben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = 42;
            LblAnzeigen.Text = x.ToString();
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = 42;
            LblAnzeigen.Text = $"Wert : {x}";
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            LblAnzeigen.Text = "Das Ergebnis der" +
                $"Berechnung: \n {x} + {y} = {z}";
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            MessageBox.Show("Das Ergebnis der" +
                $"Berechnung: \n {x} + {y} = {z}");
            LblAnzeigen.Text = "Ende";
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(
                CmdTest.Location.X + 20, CmdTest.Location.Y);
        }

        private void CmdPositionAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 150);
        }

        private void CmdGroesseRel_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(
                CmdTest.Size.Width + 20, CmdTest.Size.Height);
        }

        private void CmdGroesseAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(50, 100);
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = $"X: {CmdTest.Location.X}" +
                               $"Y: {CmdTest.Location.Y}\n" +
                               $"Breite: {CmdTest.Size.Width} " +
                               $"Höhe: {CmdTest.Size.Height}";
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            LblAnzeigen.BackColor = Color.FromArgb(192, 255, 0);
        }
    }
}
