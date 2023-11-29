using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    /// <summary>
    /// FileReader interacts with a text file.
    /// Prints the contents of that text file to the console window.
    /// </summary>
    internal class FileReader
    {
        // Set up the necessary streams and filepath information
        private StreamReader reader;
        private string filepath;


        /// <summary>
        /// Instantiates a StreamReader with a specific file.
        /// </summary>
        /// <param name="filepath">Relative filepath of the text file.</param>
        public FileReader(string filepath)
        {
            this.filepath = filepath;
            ReadFile();
        }

        /// <summary>
        /// Prints the contents of this text file to the console window.
        /// </summary>
        public void ReadFile()
        {
            try
            {
                // Open the reader with the specified filename
                this.reader = new StreamReader(filepath);

                // Read all data in the file
                // This should be in the try, because if the file wasn't opened properly, 
                //   we can't read from the file.

                // Print the beginning headline for this file's contents
                string textFromFile = "The contents of the file are:";
                Console.WriteLine(textFromFile);

                // Read every line of the file, printing to console
                while ((textFromFile = reader.ReadLine()) != null)
                {
                    Console.WriteLine(textFromFile);
                }

                // When done, close the stream.
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("An error occurred when file reading: " + error.Message);
            }
        }
    }
}
