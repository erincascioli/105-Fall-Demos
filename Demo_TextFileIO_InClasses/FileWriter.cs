using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    /// <summary>
    /// FileWriter interacts with a text file.
    /// Prints 5 hard-coded statements to that file.
    /// </summary>
    internal class FileWriter
    {
        // Set up the necessary streams and filepath information
        private StreamWriter writer;
        private string filepath;


        /// <summary>
        /// Instantiates a StreamWriter with a specific file.
        /// </summary>
        /// <param name="filepath">Relative filepath of the text file.</param>
        public FileWriter(string filepath)
        {
            this.filepath = filepath;
            WriteFile();
        }

        /// <summary>
        /// Writes 5 statements to a text file.
        /// </summary>
        public void WriteFile()
        {
            try
            {
                // Open the reader with the specified filename
                this.writer = new StreamWriter(filepath);
                
                // Write 5 hard-coded statements to the file
                writer.WriteLine("If a file does not exist,");
                writer.WriteLine("the StreamWriter will create a new file with that filename.");
                writer.WriteLine("There's no crashing upon writing to an invalid file.");
                writer.WriteLine("Although an invalid filename will write to the 'wrong' file,");
                writer.WriteLine("we would consider that a logic error.");

                // When done, close the stream.
                writer.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("An error occurred when file reading: " + error.Message);
            }
        }
    }
}
