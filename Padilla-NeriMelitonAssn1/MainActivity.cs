using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Padilla_NeriMelitonAssn1
{
    [Activity(Label = "Padilla_NeriMelitonAssn1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Change activity name at title bar
            this.Title = "Padilla-Neri";

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Set conversion for text output
            TextView txt = (TextView)FindViewById(Resource.Id.txtDateOutput);

            // Set the time into the txt varible
            txt.Text = System.DateTime.Now.ToString();

            // Set buttons
            Button btnCalcArea = (Button)FindViewById(Resource.Id.btnCalcArea);
            Button btnCalcVolume = (Button)FindViewById(Resource.Id.btnCalcVolume);

            // Set button click
            btnCalcArea.Click += BtnCalcArea_Click;
            btnCalcVolume.Click += BtnCalcVolume_Click;


        }

        void BtnCalcVolume_Click(object sender, System.EventArgs e)
        {
            // Varibles
            double lengthConverted;
            double widthConverted;
            double heightConverted;
            bool resultOp1, resultOp2, resultOp3;
            
            // Take references from length, width and height
            EditText etLengthIn = (EditText)FindViewById(Resource.Id.etLengthIn);
            EditText etWidthIn = (EditText)FindViewById(Resource.Id.etWidthIn);
            EditText etHeightIn = (EditText)FindViewById(Resource.Id.etHeightIn);
            TextView txtResultOutput = (TextView)FindViewById(Resource.Id.txtResultOutput);


            // Attempt to convert input to a number
            resultOp1 = System.Double.TryParse(etLengthIn.Text,out lengthConverted);
            resultOp2 = System.Double.TryParse(etWidthIn.Text, out widthConverted);
            resultOp3 = System.Double.TryParse(etHeightIn.Text, out heightConverted);
                
            //Test for correct input
            if (resultOp1 == true && resultOp2 == true && resultOp3 == true)
             {
                txtResultOutput.Text = (lengthConverted * widthConverted * heightConverted).ToString("0.00");
             }
            else
             {
                txtResultOutput.Text = "Error: Input is invalid or incorrect format (Volume requires all three), try again";
             }
            
        }

        void BtnCalcArea_Click(object sender, System.EventArgs args)
        {
            // Varibles
            double lenghtConverted;
            double widthConverted;
            bool resultOp1, resultOp2;

            // Take references from length and width
            EditText etLengthIn = (EditText)FindViewById(Resource.Id.etLengthIn);
            EditText etWidthIn = (EditText)FindViewById(Resource.Id.etWidthIn);
            TextView txtResultOutput = (TextView)FindViewById(Resource.Id.txtResultOutput);

            // Attempt to convert input to a number
            resultOp1 = System.Double.TryParse(etLengthIn.Text, out lenghtConverted);
            resultOp2 = System.Double.TryParse(etWidthIn.Text, out widthConverted);

            //Test for correct input
            if (resultOp1 == true && resultOp2 == true)
            {
                txtResultOutput.Text = (lenghtConverted * widthConverted).ToString("0.00");
            }
            else
            {
                txtResultOutput.Text = "Error: Input is invalid, try again";
            }

        }
    }
}

