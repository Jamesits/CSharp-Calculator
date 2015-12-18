﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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
        private Color oldColor;
        private Color AlertColor = Color.Red;
        public FrmMain()
        {
            InitializeComponent();

            _uiAutomateBackgroundWorker.WorkerReportsProgress = true;
            _uiAutomateBackgroundWorker.WorkerSupportsCancellation = true;
            LabelExpression.Text = "";
            LabelResult.Text = "0";
            oldColor = LabelResult.BackColor;
            _uiAutomateBackgroundWorker.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;
                    for (int i = 99; i > 0 && !b.CancellationPending; i -= 2)
                    {
                        b.ReportProgress(i);
                        Thread.Sleep(1);
                    }
                    for (int i = 0; i < 100 && !b.CancellationPending; i++)
                    {
                        b.ReportProgress(i);
                        Thread.Sleep(2);
                    }
                });
            _uiAutomateBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(
            delegate (object o, ProgressChangedEventArgs args)
            {
                int i = args.ProgressPercentage;
                LabelResult.BackColor = ColorBlender.Blend(oldColor, AlertColor, (double)i / 100);
            });
            _uiAutomateBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                LabelResult.BackColor = oldColor;
            });
        }

        private void btns_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            try
            {
                if (LabelResult.Text == "0") LabelResult.Text = "";
                LabelExpression.Text = LabelExpression.Text.Trim();
                if (_isExpressionStart) LabelExpression.Text = "";
                switch (btn.Text)
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
                        if (LabelResult.Text == "" && btn.Text == ".") LabelResult.Text = "0";
                        LabelResult.Text += btn.Text;
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        LabelResult.Text = LabelResult.Text.Trim().TrimEnd('.');
                        if (LabelResult.Text == "") LabelResult.Text = "0";
                        LabelExpression.Text += " " + LabelResult.Text + " " + btn.Text + " ";
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
                if (_uiAutomateBackgroundWorker.IsBusy) _uiAutomateBackgroundWorker.CancelAsync();
                while (_uiAutomateBackgroundWorker.IsBusy) Application.DoEvents();
                _uiAutomateBackgroundWorker.RunWorkerAsync();
                LabelExpression.Text = "";
            }
            finally
            {
                _isExpressionStart = (btn.Text == "=") || (btn.Text == "C") ||
                                     (LabelExpression.Text.Trim().Length == 0);
                _isNumberStart = !((btn.Text[0] < '9' && btn.Text[0] > '1') || btn.Text[0] == '.');
                LabelResult.Text = LabelResult.Text.Trim();
                LabelExpression.Text = LabelExpression.Text.Trim();
                if (LabelResult.Text == "") LabelResult.Text = "0";
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LabelResult.Text = "0";
            LabelExpression.Text = "";
        }
    }
}