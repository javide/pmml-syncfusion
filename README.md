# pmml-syncfusion
C# demo of a PMML model originally trained with Python sklearn.neural_network.MLPRegressor

## Prerequisites
  - .NET 3.1.1

## To run it
```
dotnet run
```

## Current error output
```
Starting PMML demo...
File path /space/pmml-syncfusion/model.pmml
Unhandled exception. System.Exception: Unsupported activation function
   at Syncfusion.PMML.NeuralNetworkModelHelper.ComputeActivationFunction(String activationFunction, Double initialResult, NeuralLayer neuralLayer, Int32 feedCount, Double altitude, Double neuralNetworkThreshold)
   at Syncfusion.PMML.NeuralNetworkModelHelper.EvaluateNeuralLayer(Dictionary`2 neuronValueCollection, NeuralNetworkModel neuralNetworkModel)
   at Syncfusion.PMML.NeuralNetworkModelRegression.ComputeResult(Dictionary`2 fieldValuePair, NeuralNetworkModel neuralNetworkModel, TransformationDictionary transformationDictionary)
   at Syncfusion.PMML.NeuralNetworkModelEvaluator.ProcessNeuralNetworkModelFunction(Dictionary`2 fieldValuePair, NeuralNetworkModel neuralNetworkModel)
   at Syncfusion.PMML.NeuralNetworkModelEvaluator.ComputeResult(Dictionary`2 fieldValuePair, NeuralNetworkModel neuralNetworkModel)
   at Syncfusion.PMML.NeuralNetworkModelEvaluator.GetResult(Object obj, IModelOptions modelOptions)
   at playgroundcsharp.Program.Main(String[] args) in /space/pmml-syncfusion/Program.cs:line 29
```

