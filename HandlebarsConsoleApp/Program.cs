using System;
using System.IO;
using HandlebarsConsoleApp.Models;
using HandlebarsDotNet;
using Newtonsoft.Json;

try
{
    // Path to the output directory
    string outputDirectory = Path.Combine(Environment.CurrentDirectory, "output");
    Directory.CreateDirectory(outputDirectory); // Create the output directory if it doesn't exist

    // Template file path
    string hbsFile = "retainer-agreement-template.hbs";
    string templatePath = @"C:\Users\Admin\Documents\GitHub\HandlebarsConsoleApp\HandlebarsConsoleApp\" + hbsFile;

    // Verify if the template file exists
    if (!File.Exists(templatePath))
    {
        Console.WriteLine($"Template file not found at: {templatePath}");
        return;
    }

    var templateSource = File.ReadAllText(templatePath);
    var template = Handlebars.Compile(templateSource);

    // Read contents of styles.css
    //string stylesFilePath = @"C:\Users\Admin\Documents\GitHub\HandlebarsConsoleApp\HandlebarsConsoleApp\styles.css";
    //string dynamicStyles = string.Empty;
    //if (File.Exists(stylesFilePath))
    //{
    //    dynamicStyles = File.ReadAllText(stylesFilePath);
    //}
    //else
    //{
    //    Console.WriteLine($"Styles file not found at: {stylesFilePath}");
    //}

    // Sample data
    string jsonData = "ORAData.json";
    string json = File.ReadAllText(jsonData); // TODO - For TESTING ONLY
    var data = JsonConvert.DeserializeObject<ORAModel>(json)!;

    // Render the resume HTML with dynamic CSS styles
    //var htmlContent = "<style>" + dynamicStyles + "</style>" + template(data);
    var htmlContent = template(data);

    // Output HTML to a file
    string docType = "ORA";
    string outputFile = Path.Combine(outputDirectory, $"{docType}-{data.Name}.html");
    File.WriteAllText(outputFile, htmlContent);

    Console.WriteLine($"File saved to: {outputFile}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}