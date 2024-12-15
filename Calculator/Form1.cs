using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Configuration;
using System.Web;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Result.Text = "0";
            input1Chosen = true;

        }

        private double input1;
        private double input2;
        private double total;
        private string? operation;
        private bool dividedByZero;
        private bool input1Chosen;
        private bool input2Chosen;
        private bool clickedOnEquality;
        private bool operationHappened;
        private bool someOperationHappened;
        private bool unaryOperationHappened;
        private bool getNumFromNumpad;
        private string? temp;

        

        

        private void btn0_Click(object sender, EventArgs e)
        {
            GetInput(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            GetInput(btn1.Text);

        }


        private void btn2_Click(object sender, EventArgs e)
        {
            GetInput(btn2.Text);
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            GetInput(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            GetInput(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            GetInput(btn5.Text);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            GetInput(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            GetInput(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            GetInput(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            GetInput(btn9.Text);
        }




     



        private void btnPlus_Click(object sender, EventArgs e)
        {

            OperationAction("+");
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperationAction("-");

        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperationAction("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperationAction("/");
        }








        private void btnUnary_Click(object sender, EventArgs e)
        {
            SomeOperations("unary");
           
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            SomeOperations("sqrt");
        }


        private void btnSqr_Click(object sender, EventArgs e)
        {
            SomeOperations("sqr");
        }

        private void btn1SlashX_Click(object sender, EventArgs e)
        {
            SomeOperations("1slashx");
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            SomeOperations("percent");
        }





        

     
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!clickedOnEquality)
            {
                if (operation == default && !someOperationHappened)
                {
                    string inputText;
                    if (input1 < 10 && input1 > -10 && Result.Text.Contains(".")==false)
                    {
                        input1 = 0;
                        inputText = "0";
                    }

                    
                    else
                    {
                         inputText = ClearLastDigit(Result.Text);
                        input1 = Convert.ToDouble(inputText);
                    }

                    Result.Text = inputText;

                }
               
                else if (operation != default && input1Chosen && input2Chosen && !operationHappened && !someOperationHappened &&
                   (!unaryOperationHappened || (unaryOperationHappened && getNumFromNumpad)))
                {
                    string inputText;
                        if (input2 < 10 && input2 > -10 && Result.Text.Contains(".") == false)
                        {
                            input2 = 0;
                           inputText = "0";
                        }

                        else
                        {
                            if (input2 == 0 && Result.Text.EndsWith("."))
                            {
                                input2 = 0;
                                inputText = "0";
                            }
                          else
                          {
                            inputText = ClearLastDigit(Result.Text);
                            input2 = Convert.ToDouble(inputText);
                           }
                        }

                    Result.Text = inputText;
                    
                }
                
            }

            else if(clickedOnEquality && operation != default && input1Chosen && input2Chosen && !operationHappened && !someOperationHappened &&
                  ( (!unaryOperationHappened && getNumFromNumpad) || (unaryOperationHappened && getNumFromNumpad)))
            {
                string inputText;

                if (input1 < 10 && input1 > -10 && Result.Text.Contains(".") == false)
                    {
                        input1 = 0;
                       inputText = "0";
                    }

                    else
                    {
                    inputText = ClearLastDigit(Result.Text);
                    input1 = Convert.ToDouble(inputText);
                }

                    Result.Text = inputText;
                temp= inputText;
                unaryOperationHappened = false;
            }
        }








        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!clickedOnEquality)
            {
                if (operation == default)
                {
                    if (someOperationHappened)
                    {
                        string input = $"0.";
                        input1 = Convert.ToDouble(input);

                        Result.Text = input;
                        someOperationHappened = false;
                    }

                    else if (!someOperationHappened && Result.Text.Contains(".") == false)
                    {
                        string result = $"{input1}.";
                        input1 = Convert.ToDouble(result);

                        Result.Text = result;

                    }
                }

                else if (operation == default && someOperationHappened && Result.Text.Contains(".") == false)
                {
                    string result = $"0.";
                    input1 = Convert.ToDouble(result);

                    Result.Text = result;
                    someOperationHappened = false;
                }

                else if (operation != default && !input2Chosen)
                {

                    string result = "0.";
                    input2 = Convert.ToDouble(result);

                    Result.Text = result;

                    getNumFromNumpad = false;
                    input2Chosen = true;
                    operationHappened = false;
                    someOperationHappened = false;
                }

                else if (operation != default && input2Chosen)
                {
                    if (someOperationHappened || (unaryOperationHappened && !getNumFromNumpad) || operationHappened)
                    {
                        string secondInput = "0.";
                        input2 = Convert.ToDouble(secondInput);

                        Result.Text = secondInput;
                    }

                   

                    else if (Result.Text.Contains(".") == false)
                    {
                        string result = $"{input2}.";
                        input2 = Convert.ToDouble(result);

                        Result.Text = result;
                    }

                    input2Chosen = true;
                    operationHappened = false;
                    someOperationHappened = false;

                }

            }
            else if (clickedOnEquality && input1Chosen && operation == default)
            {
                string input = $"0.";
                input1 = Convert.ToDouble(input);

                Result.Text = input;


                someOperationHappened = false;

            }

            else if (clickedOnEquality && input1Chosen && input2Chosen && operation != default)
            {
                if (getNumFromNumpad && Result.Text.Contains(".") == false && !someOperationHappened)
                {
                    string answer = $"{input1}.";
                    input1 = Convert.ToDouble(answer);

                    Result.Text = answer;
                }
                else if(!getNumFromNumpad || (getNumFromNumpad && someOperationHappened))
                {
                    string input = $"0.";
                    input1 = Convert.ToDouble(input);

                    Result.Text = input;
                }

                someOperationHappened = false;
                temp = default;
            }





        }




        private void btnClearAll_Click(object sender, EventArgs e)
        {

            if (dividedByZero)
            {
                ButtonState("activate");                
            }


            Result.Text = "0";
            input1 = 0;
            input2= 0;
            total= 0;
            clickedOnEquality = default ;
            operation = default;
            dividedByZero = default ;
            input2Chosen= default ;
            temp = default;
            operationHappened = default;
            someOperationHappened = default;
            unaryOperationHappened = default;
            getNumFromNumpad = default;
          
        }


      
        
        
        
        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (dividedByZero)
            {
                ButtonState("activate");                
            }

            if(operation==default)
            {
                Result.Text = input1.ToString() ;
            }


            if (operation != default)
            {
                if (input2Chosen == false && operation != default)
                {
                    input2 = input1;
                    input2Chosen = true;
                }

                if (input1Chosen == true && input2Chosen == true && operation != default && !operationHappened)
                {
                    BasicOperations(operation);
                }


              else  if (clickedOnEquality == false && operationHappened == true)
                {
                    input2 = input1;
                    input2Chosen = true;

                    BasicOperations(operation);

                }

                if((operation != "/" || (operation=="/" && input2!=0)) && !dividedByZero)
                {
                    input1 = total;
                    Result.Text = Convert.ToString(total);
                }

            }

                clickedOnEquality = true;
                operationHappened = false;
            someOperationHappened = false;
            unaryOperationHappened = false;
            getNumFromNumpad = false;
            temp = default;

        }
        






        private void OperationAction(string chosenOperation)
        {                   
            
             if (!clickedOnEquality && input1Chosen && input2Chosen && !operationHappened)
             {
                BasicOperations(operation);

                   if ((operation != "/" || (operation == "/" && input2 != 0)) && !dividedByZero)
                   {
                        input1 = total;
                       Result.Text = Convert.ToString(total) ;
                   }
               }            
           
            operation = chosenOperation;
            operationHappened = true;            
            clickedOnEquality=false;
            someOperationHappened = false;
            unaryOperationHappened = false;
            temp = default;
        }





        private void SomeOperations(string opertr)
        {

            if (operation == default && !input2Chosen)
            {
                if (opertr == "unary" && input1!=0)
                {
                    if(Result.Text.EndsWith(".") )
                    {
                        if (Result.Text.StartsWith("-") == false)
                        {
                            Result.Text = "-" + Result.Text;
                            input1 = Convert.ToDouble(Result.Text);
                        }

                        else if(Result.Text.StartsWith("-"))
                        {
                           Result.Text= Result.Text.Substring(1);
                            input1 = Convert.ToDouble(Result.Text);
                        }
                    }
                    else
                    input1 = -1 * input1;  
                }

                else if(opertr=="sqrt")
                {
                    input1=Math.Sqrt(input1);
                }

                else if(opertr=="sqr")
                {
                    input1 = Math.Pow(input1, 2);
                }

                else if(opertr=="1slashx")
                {
                    if (input1 == 0)
                        ButtonState("1slashx"); 
                    
                    else
                    input1 = 1 / input1;
                }

                else if(opertr=="percent")
                {
                    input1 = 0;
                }
              
                if ((opertr != "1slashx" || (opertr == "1slashx" && input1 != 0)) && !dividedByZero &&
                    (!Result.Text.EndsWith(".") || (Result.Text.EndsWith(".") && opertr!="unary")))
                {
                    Result.Text = Convert.ToString(input1);
                }
            }


            else if (operation != default && !input2Chosen)
            {
                if (opertr == "unary" && input1 != 0)
                {
                    input2 = -1 * input1; 
                }

                else if (opertr == "sqrt")
                {
                    input2 = Math.Sqrt(input1);
                }


                else if (opertr == "sqr")
                {
                    input2 = Math.Pow(input1, 2);
                }


                else if (opertr == "1slashx")
                {
                    if (input1 == 0)
                        ButtonState("1slashx");

                    else
                        input2 = 1 / input1;
                }

                else if (opertr == "percent")
                {
                    input2 = input1* input1/100;
                }

                getNumFromNumpad = false;
                input2Chosen = true;
                operationHappened = false;


                if ((opertr != "1slashx" || (opertr == "1slashx" && input1 != 0)) && !dividedByZero)
                {
                    Result.Text = Convert.ToString(input2);
                }

            }

            else if (operation != default && input1Chosen && input2Chosen && !clickedOnEquality)
            {
                if (opertr == "unary" && input2 != 0)
                {
                    if (Result.Text.EndsWith("."))
                    {
                        if (Result.Text.StartsWith("-") == false)
                        {
                            Result.Text = "-" + Result.Text;
                            input2 = Convert.ToDouble(Result.Text);
                        }

                        else if (Result.Text.StartsWith("-"))
                        {
                            Result.Text = Result.Text.Substring(1);
                            input2 = Convert.ToDouble(Result.Text);
                        }
                    }

                    else
                    {
                        if (!operationHappened)
                            input2 = -1 * input2;

                        else if (operationHappened)
                            input2 = -1 * input1;
                    }
                }

                else if (opertr == "sqrt")
                {
                    if (!operationHappened)
                        input2 = Math.Sqrt(input2);
                    
                    else if (operationHappened)
                        input2 = Math.Sqrt(input1);
                }


                else if (opertr == "sqr")
                {
                    if (!operationHappened)
                        input2 = Math.Pow(input2, 2);

                    else if (operationHappened)
                        input2 = Math.Pow(input1, 2);

                }


                else if (opertr == "1slashx")
                {
                    if (!operationHappened)
                    {
                        if (input2 == 0)
                            ButtonState("1slashx");

                        else
                            input2 = 1 / input2;
                    }

                    else if (operationHappened)
                    {

                        if (input1 == 0)
                            ButtonState("1slashx");

                        else
                            input2 = 1 / input1;


                    }
                }

                else if (opertr == "percent")
                {
                    if (!operationHappened)
                        input2 = input1 * input2 / 100;

                    else if (operationHappened)
                        input2 = input1 * input1 / 100;

                }

                
                operationHappened = false;

                if ((opertr != "1slashx" || (opertr == "1slashx" && input2 != 0)) && !dividedByZero &&
                     (!Result.Text.EndsWith(".") || (Result.Text.EndsWith(".") && opertr != "unary")))
                {
                    Result.Text = Convert.ToString(input2);
                }
            }

            else if (operation!=default && clickedOnEquality)
            {
                 if (opertr == "unary" && input1 != 0)
                {
                    if (Result.Text.EndsWith("."))
                    {
                        if (Result.Text.StartsWith("-") == false)
                        {
                            Result.Text = "-" + Result.Text;
                            input1 = Convert.ToDouble(Result.Text);
                        }

                        else if (Result.Text.StartsWith("-"))
                        {
                            Result.Text = Result.Text.Substring(1);
                            input1 = Convert.ToDouble(Result.Text);
                        }
                    }

                    else
                    input1 = -1 * input1;
                }


                else if (opertr == "sqrt")
                {
                    input1 = Math.Sqrt(input1);
                }

                else if (opertr == "sqr")
                {
                    input1 = Math.Pow(input1, 2);
                }

                else if (opertr == "1slashx")
                {
                    if (input1 == 0)
                        ButtonState("1slashx");

                    else
                        input1 = 1 / input1;
                }

                else if (opertr == "percent")
                {
                    input1 = 0;
                }

                if ((opertr != "1slashx" || (opertr == "1slashx" && input1 != 0)) && !dividedByZero &&
                     (!Result.Text.EndsWith(".") || (Result.Text.EndsWith(".") && opertr != "unary")))
                {
                    Result.Text = Convert.ToString(input1);
                }
            }

            if (opertr != "unary")
                someOperationHappened = true;

            else
               unaryOperationHappened = true;

            temp = default;
        }

        





        private void GetInput(string input)
        {
            if(dividedByZero)
            {
                ButtonState("activate");               
            }


           
            
                if (operation == default )
                {
                   input1 = Convert.ToDouble(input);                  
                
                    if (Result.Text == "0")
                        Result.Text = Convert.ToString(input1);

                    else if (clickedOnEquality || someOperationHappened)
                    {
                    if (Result.Text == "0.")
                    {
                        Result.Text += Convert.ToString(input1);
                        input1 = Convert.ToDouble(Result.Text);
                    }


                    Result.Text = Convert.ToString(input1);
                        clickedOnEquality = false;
                    }

                    
                    else 
                    {
                        Result.Text += Convert.ToString(input1);
                        input1 = Convert.ToDouble(Result.Text);
                    }

                  
                    input1Chosen = true;

                }



                else if (clickedOnEquality && !operationHappened && operation != default)
                {
                    if (temp == "0")
                        temp = default;
                    if (unaryOperationHappened && getNumFromNumpad && !Result.Text.EndsWith("."))
                        temp += input1.ToString();

                    temp += input;

                    if (Result.Text.EndsWith(".") && temp.Contains(".") == false)
                        Result.Text += temp;

                    else
                        Result.Text = temp;

                    input1 = Convert.ToDouble(Result.Text);
                    temp = Result.Text;
                }


                else if(operation!=default)
                {
                    input2 = Convert.ToDouble(input);
                    if (operationHappened)
                        Result.Text = Convert.ToString(input2);
                    else
                    {
                        if (Result.Text == "0" || someOperationHappened)
                            Result.Text = Convert.ToString(input2);
                        else
                        {
                            Result.Text += Convert.ToString(input2);
                            input2 = Convert.ToDouble(Result.Text);
                        }
                    }

                    input2Chosen = true;
                }

                getNumFromNumpad = true;

                operationHappened = false;
                someOperationHappened = false;
                unaryOperationHappened = false;
            
        }







        public void BasicOperations (string operations)
        {

            if (operations == "+")
            {

                total = input1 + input2;
            }
            else if (operations == "-")
            {
                total = input1 - input2;
            }
            else if (operations == "*")
            {
                total = input1 * input2;
            }
            else if (operations == "/")
            {

                if (input2 == 0)
                    ButtonState("deactivate");

                else if (input2 != 0)
                {
                    total = input1 / input2;
                }
            }
        }








        public string ClearLastDigit(string number)
        {
            
            string numberString = number;

            numberString= numberString.Substring(0, numberString.Length - 1);
            
            

            return numberString;
        }










        public void ButtonState(string command)
        {
            Color colors = Color.Aqua;
            bool buttonActive = false;
            if (command == "activate")
            {
                colors = Color.SeaGreen;
                buttonActive = true;
            }
            else if (command == "deactivate" || command == "1slashx")
            {
                colors = Color.DarkSlateGray;
                buttonActive = false;
            }

            btnPlus.BackColor = colors;
            btnMinus.BackColor = colors;
            btnMultiply.BackColor = colors;
            btnDivide.BackColor = colors;
            btnPoint.BackColor = colors;
            btnUnary.BackColor = colors;
            btnSqr.BackColor = colors;
            btnSqrt.BackColor = colors;
            btnPercent.BackColor = colors;
            btn1SlashX.BackColor = colors;


            btnPlus.Enabled = buttonActive;
            btnMinus.Enabled = buttonActive;
            btnMultiply.Enabled = buttonActive;
            btnDivide.Enabled = buttonActive;
            btnPoint.Enabled = buttonActive;
            btnUnary.Enabled = buttonActive;
            btnSqr.Enabled = buttonActive;
            btnSqrt.Enabled = buttonActive;
            btnPercent.Enabled = buttonActive;
            btn1SlashX.Enabled = buttonActive;

            if (command == "deactivate")
            {
                if (input1 == 0 && input2 == 0 && operation == "/")
                    Result.Text = "Undefined result";
                else if (input1 != 0 && input2 == 0 && operation == "/")
                    Result.Text = "Cannot divide";

                input1 = 0; input2 = 0; total = 0; operation = default;

                dividedByZero = true;

            }
            else if (command == "1slashx")
            {
                Result.Text = "Cannot divide";

                input1 = 0; input2 = 0; total = 0; operation = default;

                dividedByZero = true;
            }

            else if (command == "activate")
            {               
                Result.Text = "0";
                input1 = 0;
                input2 = 0;
                total = 0;
                clickedOnEquality = default;
                operation = default;
                dividedByZero = default;
                input2Chosen = default;
                temp = default;
                operationHappened = default;
                someOperationHappened = default;
                unaryOperationHappened = default;
                getNumFromNumpad = default;
            }

        }
              

        }


    

        
    




       
        
 }
