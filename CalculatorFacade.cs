using FormsPractice.Models;

namespace FormsPractice
{
    public  class CalculatorFacade : ICalculatorFacade
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorFacade(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public CalculatorNumberForm GettingModel(CalculatorNumberForm dataFromView)
        {
            var newModel = new CalculatorNumberForm();
            newModel.NumberOne = dataFromView.NumberOne;
            newModel.NumberTwo = dataFromView.NumberTwo;
            newModel.MathOperator = dataFromView.MathOperator;
            newModel.Total = dataFromView.Total;
            if(newModel.MathOperator == "+")
            {
                newModel.Total =_calculatorService.add(newModel.NumberOne, newModel.NumberTwo);
            }
            else if (newModel.MathOperator == "-")
            {
                newModel.Total = _calculatorService.subtract(newModel.NumberOne, newModel.NumberTwo);
            }
            else if (newModel.MathOperator == "*")
            {
                newModel.Total = _calculatorService.multiply(newModel.NumberOne, newModel.NumberTwo);
            }
            else
            {
                newModel.Total = _calculatorService.divide(newModel.NumberOne, newModel.NumberTwo);
            }
            return newModel;
        }
    }
}