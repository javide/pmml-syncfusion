using System;
using Syncfusion.PMML;
using System.IO;

// https://help.syncfusion.com/predictive-analytics/pmml-execution-engine/working-with-pmml-execution-engine

namespace playgroundcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PMML demo...");
            
            var predictors = new           
                {
                predictor_1 = 0.3,
                predictor_2 = 0.2,
                predictor_3 = 3.2,
                predictor_4 = 1.2
                };

            string fileName = "model.pmml";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            Console.WriteLine("File path " + path);

            PMMLEvaluator PMMLEvaluator = new PMMLEvaluatorFactory().GetPMMLEvaluatorInstance(path);

            PredictedResult predictedResult = PMMLEvaluator.GetResult(predictors, null);                
        }
    }
}
