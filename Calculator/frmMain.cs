using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        private readonly ExpressionEvaluator _evaluator = new ExpressionEvaluator();
        private bool _isExpressionStart = true;
        private bool _isNumberStart = true;
        private BackgroundWorker _uiAutomateBackgroundWorker = new BackgroundWorker();
        private Color oldColor = Color.White;
        private Color AlertColor = Color.Red;

        public FrmMain()
        {
            InitializeComponent();

            _uiAutomateBackgroundWorker.WorkerReportsProgress = true;
            _uiAutomateBackgroundWorker.WorkerSupportsCancellation = true;
            LabelExpression.Text = "";
            LabelResult.Text = "0";
            //oldColor = LabelResult.BackColor;
            _uiAutomateBackgroundWorker.DoWork += delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                if (b == null) return;
                for (int i = 99; i > 0 && !b.CancellationPending; i -= 4)
                {
                    b.ReportProgress(i);
                    Thread.Sleep(2);
                }
                for (int i = 0; i < 100 && !b.CancellationPending; i++)
                {
                    b.ReportProgress(i);
                    Thread.Sleep(2);
                }
            };
            _uiAutomateBackgroundWorker.ProgressChanged += delegate(object o, ProgressChangedEventArgs args)
            {
                int i = args.ProgressPercentage;
                Color c = ColorBlender.Blend(oldColor, AlertColor, (double) i/100);
                LabelResult.BackColor = c;
                LabelExpression.BackColor = c;
                this.BackColor = c;
            };
            _uiAutomateBackgroundWorker.RunWorkerCompleted += delegate
            {
                LabelResult.BackColor = oldColor;
                LabelExpression.BackColor = oldColor;
                this.BackColor = oldColor;
            };
        }

        private void onError()
        {
            if (_uiAutomateBackgroundWorker.IsBusy) _uiAutomateBackgroundWorker.CancelAsync();
            while (_uiAutomateBackgroundWorker.IsBusy) Application.DoEvents();
            _uiAutomateBackgroundWorker.RunWorkerAsync();
        }

        private void processKeys(string keyString)
        {
            try
            {
                if (LabelResult.Text == "0") LabelResult.Text = "";
                LabelExpression.Text = LabelExpression.Text.Trim();
                if (_isExpressionStart) LabelExpression.Text = "";
                switch (keyString)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "0":
                    case ".":
                        if (_isNumberStart) LabelResult.Text = "";
                        if (LabelResult.Text == "" && keyString == ".") LabelResult.Text = "0";
                        if (LabelResult.Text.Length > 10) throw new InvalidOperationException("Too long");
                        LabelResult.Text += keyString;
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        if (_isNumberStart && !_isExpressionStart) break;
                        LabelResult.Text = LabelResult.Text.Trim().TrimEnd('.');
                        if (LabelResult.Text == "") LabelResult.Text = "0";
                        LabelExpression.Text += " " + LabelResult.Text + " " + keyString + " ";
                        break;
                    case "+/-":
                        if (LabelResult.Text != "")
                            LabelResult.Text = LabelResult.Text[0] == '-'
                                ? LabelResult.Text.Substring(1)
                                : "-" + LabelResult.Text;
                        break;
                    case "DEL":
                        LabelResult.Text = LabelResult.Text.Remove(LabelResult.Text.Length - 1);
                        if (LabelResult.Text == "-") LabelResult.Text = "";
                        break;
                    case "C":
                        if (LabelResult.Text == "" && LabelResult.Text == "") throw new InvalidOperationException();
                        LabelExpression.Text = "";
                        LabelResult.Text = "";
                        break;
                    case "CE":
                        if (LabelResult.Text == "") throw new InvalidOperationException();
                        LabelResult.Text = "";
                        break;
                    case "=":
                        LabelExpression.Text += " " + LabelResult.Text;
                        LabelResult.Text = _evaluator.Evaluate(LabelExpression.Text).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                onError();
                LabelExpression.Text = "";
            }
            finally
            {
                _isExpressionStart = (keyString == "=") || (keyString == "C") ||
                                     (LabelExpression.Text.Trim().Length == 0);
                _isNumberStart = !((keyString[0] <= '9' && keyString[0] >= '0') || keyString[0] == '.');
                LabelResult.Text = LabelResult.Text.Trim(); //.TrimStart('0');
                LabelExpression.Text = LabelExpression.Text.Trim();
                if (LabelResult.Text == "") LabelResult.Text = "0";
            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            processKeys(btn.Text);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LabelResult.Text = "0";
            LabelExpression.Text = "";
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                case Keys.Back:
                    processKeys("DEL");
                    break;
                case Keys.C:
                    processKeys("C");
                    break;
                case Keys.E:
                    processKeys("CE");
                    break;
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            processKeys(e.KeyChar.ToString());
        }
    }
}
