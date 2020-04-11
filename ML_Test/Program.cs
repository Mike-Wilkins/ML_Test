using System;
using ML_TestML.Model;


namespace ML_Test
{
    class Program
    {
        static void Main(string[] args)
        {


            // Add input data
            var input = new ModelInput();
            input.Trip_distance = 100;
            input.Trip_time_in_secs = 1000;
            input.Passenger_count = 3;
            input.Payment_type = "CSH";
            input.Rate_code = 1;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"Prediction: ${result.Score}");

            Console.ReadLine();


        }
    }
}
