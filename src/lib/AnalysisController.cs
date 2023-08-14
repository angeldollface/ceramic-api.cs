/*
CERAMIC-API.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Importing the namespace.
using LuhnyLib;

// Importing the Luhny class.
using static LuhnyLib.Luhny;

// Importing Microsoft's standard
// MVC API.
using Microsoft.AspNetCore.Mvc;

// Defining a namespace
// for the views the app holds.
namespace CoreApp{

    // A class to serialize and store
    // analysis results.
    public class AnalysisResult {
        public string Number { get; set; }
        public bool Result { get; set; }
    }

    // A controller for conduting the analysis
    // on the IMEI number.
    public class AnalysisController : Controller {

        // Rhe route that takes the IMEI number
        // as a route parameter and returns a processed
        // JSON object.
        [Route("{imei}")]
        public IActionResult Analyse(string imei){
            var analysisResult = new AnalysisResult{
                Number = imei,
                Result = Luhny.validateIMEI(imei)
            };
            return Ok(analysisResult);
        }
    }
}