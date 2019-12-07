using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireMath
{
    public partial class Form1 : Form
    {
        double[,] input = new double[61, 61];
        double[,] output = new double[3, 3727];
        double[,] multipliedOutput = new double[3, 3727];
        double[,] plottedOutput = new double[2, 3727];
        double rad_X = 0;
        double rad_Y = 0;
        double rad_Z = 0;
        Graphics drawArea;

        private enum Precedence
        {
            None = 11,
            Unary = 10,     // Not actually used.
            Power = 9,      // We use ^ to mean exponentiation.
            Times = 8,
            Div = 7,
            Modulus = 6,
            Plus = 5,
        }

        private void SetAngles()
        {
            try
            {
                string[] arrayCord = xYBox.Text.Split(',');
                switch (arrayCord.Length)
                {
                    case 1:
                        rad_X = double.Parse(arrayCord[0]);
                        break;
                    case 2:
                        rad_X = double.Parse(arrayCord[0]);
                        rad_Y = double.Parse(arrayCord[1]);
                        break;
                    case 3:
                        rad_X = double.Parse(arrayCord[0]);
                        rad_Y = double.Parse(arrayCord[1]);
                        rad_Z = double.Parse(arrayCord[2]);
                        break;
                }
                anglLabel.Text = $"X = {rad_X}, Y = {rad_Y}, Z = {rad_Z}";
            } catch (Exception)
            {
                MessageBox.Show("Incorrect angles entered.\n Defaulting: \nX = 0\nY = 0\nZ = 0");
                rad_X = 0;
                rad_Y = 0;
                rad_Z = 0;
                anglLabel.Text = $"X = {rad_X}, Y = {rad_Y}, Z = {rad_Z}";
                xYBox.Text = $"{rad_X},{rad_Y},{rad_Z}";
            }
        }
        private bool DoingWork = false;
        //Evaluate the expression entered by the user.
        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (DoingWork == true) { return; }
            DoingWork = true;
            SetAngles();
           double[,] axesMatrix = CreateRotationMatrix(rad_X,rad_Y,rad_Z);
           
            
            RotateAndDisplay(axesMatrix);
            DoingWork = false;

        }

         private static double[,] CreateRotationMatrix(double rad_X, double rad_Y, double rad_Z)
        {
             double[,] rotation_X = { { 1, 0, 0 }, { 0, Math.Cos(rad_X), -1*Math.Sin(rad_X) },
                                         {0,Math.Sin(rad_X),Math.Cos(rad_X) } };
            double[,] rotation_Y = { {Math.Cos(rad_Y),0,Math.Sin(rad_Y) }, {0,1,0 },
                                        {-1*Math.Sin(rad_Y),0,Math.Cos(rad_Y) } };
            double[,] rotation_Z = { {Math.Cos(rad_Z),-1*Math.Sin(rad_Z),0 },
                                      {Math.Sin(rad_Z),Math.Cos(rad_Z),0 }, {0,0,1 } };
            double[,] rotation_XY = new double[3, 3];
            double[,] rotation_XYZ = new double[3, 3];

            MultiplyMatrix rotation = new MultiplyMatrix();
            rotation.Multiply_twoD(rotation_X, rotation_Y, rotation_XY);
            rotation.Multiply_twoD(rotation_XY, rotation_Z, rotation_XYZ);

           
            return rotation_XYZ;
        }

       

        // Evaluate the expression.

        private double EvaluateExpression(string expression, double a, double b)
        {
            int best_pos = 0;
            int parens = 0;

            // Remove all spaces.
            string expr = expression.Replace(" ", "");
            int expr_len = expr.Length;
            if (expr_len == 0) return 0;

            // If we find + or - now, then it's a unary operator.
            bool is_unary = true;

            // So far we have nothing.
            Precedence best_prec = Precedence.None;

            // Find the operator with the lowest precedence.
            // Look for places where there are no open
            // parentheses.
            for (int pos = 0; pos < expr_len; pos++)
            {
                // Examine the next character.
                string ch = expr.Substring(pos, 1);

                // Assume we will not find an operator. In
                // that case, the next operator will not
                // be unary.
                bool next_unary = false;

                if (ch == " ")
                {
                    // Just skip spaces. We keep them here
                    // to make the error messages easier to
                }
                else if (ch == "(")
                {
                    // Increase the open parentheses count.
                    parens += 1;

                    // A + or - after "(" is unary.
                    next_unary = true;
                }
                else if (ch == ")")
                {
                    // Decrease the open parentheses count.
                    parens -= 1;

                    // An operator after ")" is not unary.
                    next_unary = false;

                    // If parens < 0, too many )'s.
                    if (parens < 0)
                        throw new FormatException(
                            "Too many close parentheses in '" +
                            expression + "'");
                }
                else if (parens == 0)
                {
                    // See if this is an operator.
                    if ((ch == "^") || (ch == "*") ||
                        (ch == "/") || (ch == "\\") ||
                        (ch == "%") || (ch == "+") ||
                        (ch == "-"))
                    {
                        // An operator after an operator
                        // is unary.
                        next_unary = true;

                        // See if this operator has higher
                        // precedence than the current one.
                        switch (ch)
                        {
                            case "^":
                                if (best_prec >= Precedence.Power)
                                {
                                    best_prec = Precedence.Power;
                                    best_pos = pos;
                                }
                                break;

                            case "*":
                            case "/":
                                if (best_prec >= Precedence.Times)
                                {
                                    best_prec = Precedence.Times;
                                    best_pos = pos;
                                }
                                break;

                            case "%":
                                if (best_prec >= Precedence.Modulus)
                                {
                                    best_prec = Precedence.Modulus;
                                    best_pos = pos;
                                }
                                break;

                            case "+":
                            case "-":
                                // Ignore unary operators
                                // for now.
                                if ((!is_unary) &&
                                    best_prec >= Precedence.Plus)
                                {
                                    best_prec = Precedence.Plus;
                                    best_pos = pos;
                                }
                                break;
                        } // End switch (ch)
                    } // End if this is an operator.
                } // else if (parens == 0)

                is_unary = next_unary;
            } // for (int pos = 0; pos < expr_len; pos++)

            // If the parentheses count is not zero,
            // there's a ) missing.
            if (parens != 0)
            {
                throw new FormatException(
                    "Missing close parenthesis in '" +
                    expression + "'");
            }

            // Hopefully we have the operator.
            if (best_prec < Precedence.None)
            {
                string lexpr = expr.Substring(0, best_pos);
                string rexpr = expr.Substring(best_pos + 1);
                switch (expr.Substring(best_pos, 1))
                {
                    case "^":
                        return Math.Pow(
                            EvaluateExpression(lexpr,a,b),
                            EvaluateExpression(rexpr,a,b));
                    case "*":
                        return
                            EvaluateExpression(lexpr,a,b) *
                            EvaluateExpression(rexpr,a,b);
                    case "/":
                        return
                            EvaluateExpression(lexpr,a,b) /
                            EvaluateExpression(rexpr,a,b);
                    case "%":
                        return
                            EvaluateExpression(lexpr,a,b) %
                            EvaluateExpression(rexpr,a,b);
                    case "+":
                        return
                            EvaluateExpression(lexpr,a,b) +
                            EvaluateExpression(rexpr,a,b);
                    case "-":
                        return
                            EvaluateExpression(lexpr,a,b) -
                            EvaluateExpression(rexpr,a,b);
                }
            }

            // if we do not yet have an operator, there
            // are several possibilities:
            //
            // 1. expr is (expr2) for some expr2.
            // 2. expr is -expr2 or +expr2 for some expr2.
            // 3. expr is Fun(expr2) for a function Fun.
            // 4. expr is a primitive.
            // 5. It's a literal like "3.14159".

            // Look for (expr2).
            if (expr.StartsWith("(") && expr.EndsWith(")"))
            {
                // Remove the parentheses.
                return EvaluateExpression(expr.Substring(1, expr_len - 2),a,b);
            }

            // Look for -expr2.
            if (expr.StartsWith("-"))
            {
                return -EvaluateExpression(expr.Substring(1),a,b);
            }

            // Look for +expr2.
            if (expr.StartsWith("+"))
            {
                return EvaluateExpression(expr.Substring(1),a,b);
            }

            // Look for Fun(expr2).
            if (expr_len > 5 && expr.EndsWith(")"))
            {
                // Find the first (.
                int paren_pos = expr.IndexOf("(");
                if (paren_pos > 0)
                {
                    // See what the function is.
                    string lexpr = expr.Substring(0, paren_pos);
                    string rexpr = expr.Substring(paren_pos + 1, expr_len - paren_pos - 2);
                    switch (lexpr.ToLower())
                    {
                        case "sin":
                            return Math.Sin(EvaluateExpression(rexpr,a,b));
                        case "cos":
                            return Math.Cos(EvaluateExpression(rexpr,a,b));
                        case "tan":
                            return Math.Tan(EvaluateExpression(rexpr,a,b));
                        case "sqrt":
                            return Math.Sqrt(EvaluateExpression(rexpr,a,b));
                        case "factorial":
                            return Factorial(EvaluateExpression(rexpr,a,b));
                            // Add other functions (including
                            // program-defined functions) here.
                    }
                }
            }

            // Check if it contains x or y or both.
            bool has_x = false;
            bool has_y = false;
            for (int i = 0; i < expr.Length; i++)
            {
                string m = expr.Substring(i, 1);
                if (m.ToLower() == "x")
                    has_x = true;
                if (m.ToLower() == "y")
                    has_y = true;

            }
                if(expr.ToLower() == "x" )
                {
               
                   return a;
                   

                }

          else  if ( expr.ToLower() == "y")
            {
                // Return the corresponding value,
                // converted into a Double.
                try
                {
                    // Try to convert the expression into a value.
                    return b;
                }
                catch (Exception)
                {
                    throw new FormatException(
                        "Try again.");
                }
            }


            // It must be a literal like "2.71828".
            try
            {
                    // Try to convert the expression into a Double.
                    return double.Parse(expr);
                }
                catch (Exception)
                {
                    throw new FormatException(
                        "Error evaluating '" + expression +
                        "' as a constant.");
                }
            
        }

        // Return the factorial of the expression.
        private double Factorial(double value)
        {
            // Make sure the value is an integer.
            if ((long)value != value)
            {
                throw new ArgumentException(
                    "Parameter to Factorial function must be an integer in Factorial(" +
                    value.ToString() + ")");
            }

            double result = 1;
            for (int i = 2; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        
            

        }

        private void RotateAndDisplay(double[,]R_matrix)
        {
            plottedOutput = null;
            output = null;
            multipliedOutput = null;
            plottedOutput = new double[2, 3727];
            multipliedOutput = new double[3, 3727];
            output = new double[3, 3727];
            // Get the expression.
            string expr = txtbxExpression.Text;
            int i = -30, j = -30,  c = 0;
            // Evaluate the expression.

            double x, y;
            try
            {
                
                for (; i < 31; i++)     //storing each "point" in columns of a 3 by n matrix.
                {
                    for (int r = 0; j < 31; j++, c++)
                    {
                        x = (double)i / 3;
                        y = (double)j / 3;
                        output[r, c] = x;
                        output[r + 1, c] = y;
                        output[r + 2, c] = EvaluateExpression(expr, x, y);
//                        
                        r = 0;
                    }
                    j = -30;
                }

                output[0, c] = 0;output[1, c] = 0;output[2, c] = 10000;
                output[0, c+1] = 0; output[1, c+1] = 0; output[2, c+1] = -10000;
                output[0, c+2] = 0; output[1, c+2] = 10000; output[2, c+2] = 0;
                output[0, c+3] = 0; output[1, c+3] = -10000; output[2, c+3] = 0;
                output[0, c+4] = 10000; output[1, c+4] = 0; output[2, c+4] = 0;
                output[0, c+5] = -10000; output[1, c+5] = 0; output[2, c+5] = 0;

                MultiplyMatrix rotationmult = new MultiplyMatrix();
                rotationmult.Multiply_twoD(R_matrix, output, multipliedOutput);
                //Code to change the values of the rotation values of x and y goes here.

                CreatePlottableArray(plottedOutput, multipliedOutput);
                Pen bluePen = new Pen(Color.Blue);
                Pen blackPen = new Pen(Color.Black,3);
                blackPen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                blackPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                drawArea.Clear(Color.White);

                for (int n = 0; n < 3; n++)
                {
                    drawArea.DrawLine(blackPen, (float)(211 + plottedOutput[0, c + n]), (float)(174 - plottedOutput[1, c + n]),
                    (float)(211 + plottedOutput[0, c + n + 1]), (float)(174 - plottedOutput[1, c + n + 1]));
                    c++;
                }

                int m = 0;
                for ( i = 0; i < 60; i++)
                {
                    for ( j = 0; j<60; j++)
                    {

                    m = 61 * i + j;
                    
                            
                drawArea.DrawLine(bluePen, (float)(211 + plottedOutput[0, m]), (float)(174 - plottedOutput[1, m]),
                    (float)(211 + plottedOutput[0, m + 1]), (float)(174 - plottedOutput[1, m + 1]));
                    drawArea.DrawLine(bluePen, (float)(211 + plottedOutput[0, m]), (float)(174 - plottedOutput[1, m]),
                        (float)(211 + plottedOutput[0, m + 61]), (float)(174 - plottedOutput[1, m + 61]));

                    
                     }
                }

              
                txtbxResult.Text = (plottedOutput[0, 61]).ToString();
            }

          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        //Deletes the x coordinate by collecting the y and z coordinates into another array.

        private void CreatePlottableArray(double[,] two_Row, double[,] three_Row)
        {
            int i = -30, j = -30; int c = 0;
            for (; i < 31; i++)
            {                            //storing each "point" in columns of a 2 by n matrix.
                for (int r = 0; j < 31; j++, c++)
                {
                    plottedOutput[r, c] = 400 * (multipliedOutput[r + 1, c]) / (40 - multipliedOutput[0, c]);
                    plottedOutput[r + 1, c] = 400 * (multipliedOutput[r + 2, c]) / (40 - multipliedOutput[0, c]);
                    r = 0;
                }
                j = -30;
            }
            for (int n = 0; n < 6; n++)
            {
                plottedOutput[0, c + n] = (multipliedOutput[1, c + n])/(40-multipliedOutput[0,c+n]);
                plottedOutput[1, c + n] = (multipliedOutput[2, c + n])/(40-multipliedOutput[0,c+n]);
            }
        }

        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
            xYBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveGraph(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveGraph(2);
        }

        private void MoveGraph(int value)
        {
            switch (value)
            {
                case 1:
                    xYBox.Text = $"{rad_X + .5},{rad_Y},{rad_Z}";
                    break;
                case 2:
                    xYBox.Text = $"{rad_X},{rad_Y},{rad_Z + .5}";
                    break;
            }
            btnGraph_Click(this, new EventArgs());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rad_X = 0;
            rad_Y = 0;
            rad_Z = 0;
            xYBox.Text = $"{rad_X},{rad_Y},{rad_Z}";
            btnGraph_Click(this, new EventArgs());
        }

      
    }
}
