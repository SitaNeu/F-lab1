using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    
    public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){
 
            if(Request.Form["Add"]=="Add"){
 
                ViewData["summation"]=double.Parse(Request.Form["num1"])+double.Parse(Request.Form["num2"]);
 
            }

            
            if(Request.Form["Sub"]=="Sub"){
 
                ViewData["subtration"]=double.Parse(Request.Form["num1"])-double.Parse(Request.Form["num2"]);
 
            }

            
            if(Request.Form["Divide"]=="Divide"){
 
                ViewData["Division"]=double.Parse(Request.Form["num1"])/double.Parse(Request.Form["num2"]);
 
            }

            
            
            if(Request.Form["Multiply"]=="Multiply"){
 
                ViewData["Multiplication"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"]);
 
            }
             

             
            if(Request.Form["Square"]=="Square"){
 
                ViewData["square"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
 
            }

            
            if(Request.Form["Cube"]=="Cube"){
 
                ViewData["Cubing"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
 
            }

             
            if(Request.Form["Power"]=="Power"){
 
                ViewData["power"]=Math.Pow(double.Parse(Request.Form["num1"]),double.Parse(Request.Form["num2"]));
 
            }

 
 
        }
 
 
    }

}

