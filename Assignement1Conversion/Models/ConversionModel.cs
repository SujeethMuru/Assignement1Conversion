namespace Assignement1Conversion.Models
{
    public class ConversionModel
    {
        public string ConversionType { get; set; }
        public string ConversionOption { get; set; }
        public decimal InputValue { get; set; }

        public decimal Convert()
        {
            decimal result = 0;
            switch (ConversionType)
            {
                case "Length":
       
                    if (ConversionOption == "KilometersToMiles")
                    {
                        result = InputValue * 0.621371m;
                    }
                    else if (ConversionOption == "MilesToKilometers")
                    {
                        result = InputValue / 0.621371m;
                    }
                    else if (ConversionOption == "YardToFeet")
                    {
                        result = InputValue * 3;
                    }
                    else if (ConversionOption == "FeetToYard")
                    {
                        result = InputValue / 3;
                    }
                    else if (ConversionOption == "InchesToCentimeters")
                    {
                        result = InputValue * 2.54m;
                    }
                    else if (ConversionOption == "CentimetersToInches")
                    {
                        result = InputValue / 2.54m;
                    }
                    break;

                case "Liquid:":
                    if (ConversionOption == "LitersToGallons")
                    {
                        result = InputValue * 0.264172m;
                    }
                    else if (ConversionOption == "GallonsToLiters")
                    {
                        result = InputValue / 0.264172m;
                    }
                    else if (ConversionOption == "QuartsToGallons")
                    {
                        result = InputValue * 0.25m;
                    }
                    else if (ConversionOption == "GallonsToQuarts")
                    {
                        result = InputValue / 0.25m;
                    }
                    break;
                    

                case "Temperature":
                    if (ConversionOption == "CelsiusToFahrenheit")
                    {
                        result = (InputValue * 9 / 5) + 32;
                    }
                    else if (ConversionOption == "FahrenheitToCelsius")
                    {
                        result = (InputValue - 32) * 5 / 9;
                    }
                    break;
                    
                case "Mass":
                    if (ConversionOption == "KilogramsToPounds")
                    {
                        result = InputValue * 2.20462m;
                    }
                    else if (ConversionOption == "PoundsToKilograms")
                    {
                        result = InputValue / 2.20462m;
                    }
                    else if (ConversionOption == "OuncesToGrams")
                    {
                        result = InputValue * 28.3495m;
                    }
                    else if (ConversionOption == "GramsToOunces")
                    {
                        result = InputValue / 28.3495m;
                    }
                    break;
            }
            return result;
        }

        //public string CheckForErrors()
        //{ 

        //}

    }
}
