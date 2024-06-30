using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Image Converter Automation - Developed by Ahmet Erdem Pamuk\n");

        // Get the photo path to convert 
        Console.Write("Enter the path of the image file you want to convert: (example: C:\\Users\\Username\\Desktop\\input.ico) ");
        string inputPath = Console.ReadLine();

        // Check if the input path is null or empty
        if (string.IsNullOrEmpty(inputPath))
        {
            throw new ArgumentNullException(nameof(inputPath), "The input path cannot be null or empty."); // Give error message if inputPath is null
        }

        // Get the format to convert
        Console.Write("Enter the target format (ico, png, jpg, bmp, gif, webp, tiff): ");
        string targetFormat = Console.ReadLine().ToLower();

        // Check if the target format is null or empty
        if (string.IsNullOrEmpty(targetFormat))
        {
            throw new ArgumentNullException(nameof(targetFormat), "The target format cannot be null or empty."); // Give error message if targetFormat is null
        }

        // Check if file exists in inputPath
        if (File.Exists(inputPath))
        {
            try
            {
                // Get the file extension
                string extension = Path.GetExtension(inputPath).ToLower();

                // Check if the file extension is null
                if (extension == null)
                {
                    throw new ArgumentException("File extension could not be determined."); // Give error message if extension is null
                }

                // Check if same type is converted to same type
                if (extension == targetFormat)
                {
                    //Get the output path
                    Console.Write("Enter the full path where you want to save the file (example: C:\\Users\\Username\\Desktop\\output.ico): ");
                    string outputPath = Console.ReadLine();

                    // Check if outputPath is null and contains invalid characters
                    while (string.IsNullOrEmpty(outputPath) || Path.GetInvalidPathChars().Any(c => outputPath.Contains(c)))
                    {
                        Console.Write("Invalid path. Please enter a valid path for saving the file:"); // If the outputPath is not suitable, get a new outputPath
                        outputPath = Console.ReadLine();
                    }

                    // Copy the same file if an attempt is made to convert the same type of file
                    File.Copy(inputPath, outputPath, true);
                    Console.WriteLine($"File successfully copied to {outputPath}.");
                }
                else
                {
                    // Load the image
                    using (Image image = Image.FromFile(inputPath))
                    {
                        // Check if the image is null
                        if (image == null)
                        {
                            throw new ArgumentNullException(nameof(image), "The image could not be loaded."); // Give error message if image is null
                        }

                        // Set target format
                        ImageFormat format = targetFormat switch
                        {
                            "png" => ImageFormat.Png,
                            "jpg" => ImageFormat.Jpeg,
                            "bmp" => ImageFormat.Bmp,
                            "gif" => ImageFormat.Gif,
                            "ico" => ImageFormat.Icon,
                            "webp" => ImageFormat.Webp,
                            "tiff" => ImageFormat.Tiff,
                            _ => throw new ArgumentException("Unsupported format!") // If the above conditions are not met, give an error message
                        };

                        // Get the output path
                        Console.Write("Enter the full path where you want to save the file (e.g., C:\\Users\\username\\Desktop\\output.png): ");
                        string outputPath = Console.ReadLine();

                        // Check if outputPath is null and contains invalid characters
                        while (string.IsNullOrEmpty(outputPath) || Path.GetInvalidPathChars().Any(c => outputPath.Contains(c)))
                        {
                            Console.Write("Invalid path. Please enter a valid path for saving the file:"); // If the outputPath is not suitable, get a new outputPath
                            outputPath = Console.ReadLine();
                        }

                        // Save the image in the target format
                        image.Save(outputPath, format);
                        Console.WriteLine($"Image successfully saved as {targetFormat} format at {outputPath}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}"); // Give the error message
            }
        }
        else
        {
            Console.WriteLine("The specified file was not found."); 
        }
    }
}