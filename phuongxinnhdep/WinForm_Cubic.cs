using System;
using System.Windows.Forms;
using Personal.CubicLib;


public class MainForm : Form
{
    private TextBox ta, tb, tc, td, tout;
    private Button solveBtn;

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1219, 541);
            this.Name = "MainForm";
            this.ResumeLayout(false);

    }

    private Label sig;


    public MainForm()
    {
        this.Text = "Phuong Ngu Cubic Solver";
        this.Width = 420; this.Height = 320;


        Label la = new Label(); la.Text = "a:"; la.Left = 10; la.Top = 20; this.Controls.Add(la);
        ta = new TextBox(); ta.Left = 40; ta.Top = 18; ta.Width = 100; ta.Text = "1"; this.Controls.Add(ta);


        Label lb = new Label(); lb.Text = "b:"; lb.Left = 160; lb.Top = 20; this.Controls.Add(lb);
        tb = new TextBox(); tb.Left = 190; tb.Top = 18; tb.Width = 100; this.Controls.Add(tb);


        Label lc = new Label(); lc.Text = "c:"; lc.Left = 10; lc.Top = 60; this.Controls.Add(lc);
        tc = new TextBox(); tc.Left = 40; tc.Top = 58; tc.Width = 100; this.Controls.Add(tc);


        Label ld = new Label(); ld.Text = "d:"; ld.Left = 160; ld.Top = 60; this.Controls.Add(ld);
        td = new TextBox(); td.Left = 190; td.Top = 58; td.Width = 100; this.Controls.Add(td);


        solveBtn = new Button(); solveBtn.Text = "Solve"; solveBtn.Left = 10; solveBtn.Top = 100; solveBtn.Click += new EventHandler(SolveClick); this.Controls.Add(solveBtn);


        tout = new TextBox(); tout.Left = 10; tout.Top = 140; tout.Width = 380; tout.Height = 100; tout.Multiline = true; tout.ReadOnly = true; this.Controls.Add(tout);


        sig = new Label(); sig.Left = 10; sig.Top = 250; sig.Width = 380; sig.Text = "~ Phuong Ngu CubicSolver v1.0"; this.Controls.Add(sig);
    }


    private void SolveClick(object sender, EventArgs e)
    {
        try
        {
            double a = Double.Parse(ta.Text);
            double b = Double.Parse(tb.Text);
            double c = Double.Parse(tc.Text);
            double d = Double.Parse(td.Text);
            CubicSolver solver = new CubicSolver();
            solver.A = a; solver.B = b; solver.C = c; solver.D = d;
            string msg = solver.Solve();
            tout.Text = msg + "\r\n";
            double[] roots = solver.Roots;
            if (roots != null && roots.Length > 0)
            {
                for (int i = 0; i < roots.Length; i++)
                    tout.Text += string.Format("x{0} = {1:0.######}\r\n", i + 1, roots[i]);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }


    [STAThread]
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}