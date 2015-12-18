using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DynamicExpresso;

namespace Calculator
{
    class ExpressionEvaluator
    {
        private readonly Interpreter _interpreter = new Interpreter();

        public struct HistoryEntry
        {
            public string Expression;
            public double Value;
        }

        public List<HistoryEntry> History { get; } = new List<HistoryEntry>();

        private double EvaluateRawExpression(string expression)
        {
            if (expression == "") return 0;
            return double.Parse(_interpreter.Eval(expression).ToString());
        }

        private string FixBracelets(string expression)
        {
            string[] a = expression.Trim().Split(' ');
            expression = "";
            foreach (var i in a)
            {
                try
                {
                    expression += " " + double.Parse(i).ToString("0.0################") + " ";
                }
                catch (FormatException)
                {
                    expression += " " + i + " ";
                }
            }
            expression = expression.Trim();
            var braceletCount = 0;
            foreach (var t in expression)
            {
                if (t == '(') braceletCount++;
                if (t == ')') braceletCount--;
                if (braceletCount < 0) throw new ArgumentException(nameof(expression));
            }
            return expression + new string(')', braceletCount);
        }

        public double Evaluate(string expression)
        {
            var result = EvaluateRawExpression(FixBracelets(expression));
            var newExpression = new HistoryEntry
            {
                Expression = expression,
                Value = result
            };
            History.Add(newExpression);
            return result;
        }
    }
}
