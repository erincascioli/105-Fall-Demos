using System;
using System.Collections.Generic;
using System.IO;

// Erin Cascioli
// 11/29/2021
// Demo: File IO (Text only, no classes, simple string data)

namespace SimpleTextFileIO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

			// FIRST ADD SYSTEM.IO USING STATEMENT!

			// -------------------------------------------------------------------------
			// Variable Setup ----------------------------------------------------------
			// -------------------------------------------------------------------------
			// These lists are used in the second region below.  
			// I needed to add using System.Collections.Generic; to access the List class.
			List<string> enemyNames = new List<string>();
			List<string> enemyHealths = new List<string>();
			List<string> enemyWeapons = new List<string>();

            #region Stream and Filepath Setup for File Reading and Writing
            // -------------------------------------------------------------------------
            // Stream and Filepath Setup ----------------------------------------------
            // -------------------------------------------------------------------------
            // Declare Streams for later use.  
            // This will come in handy next class!  
            StreamReader reader = null;
			StreamWriter writer = null;

			// Filenames could be stored as strings, or they can be passed directly
			//   into a Stream constructor without a string variable.
			// I prefer saving as a string variable whenever I can.  It's organized well
			//   and is easy to find to change the file path if needed. 
			string filenameToRead = "../../../dataRead.txt";
			string filenameToWrite = "../../../dataWrite.txt";
			string filenameToReadAndWrite = "../../../allData.txt";
			#endregion


			#region File Reading and Writing
			// This part of the demo reads from one file and writes to a different file. 
			// Reads from: dataRead.txt
			// Writes to:  dataWrite.txt

			Console.WriteLine(
				"********************************************************\n" + 
				"This part of the demo is doing file reading and writing.\n");

			// -------------------------------------------------------------------------
			// File Reading ------------------------------------------------------------
			// -------------------------------------------------------------------------
			// Step 1: Open the stream, pass in filename
			//  - When the file is done reading and each line of text is 
			//    done being read, null will be returned.
			//  - Exception could be thrown if filename is incorrect.
			try
			{
				reader = new StreamReader(filenameToRead);

				// Step 2:  Read all data from the file, line by line
				string lineOfTextFromFile = null;
				while ((lineOfTextFromFile = reader.ReadLine()) != null)
				{
					// Print to the console to test that we properly read the file.
					Console.WriteLine("The entire line is: " + lineOfTextFromFile);

					// Now that the data has been read into a string, you can use
					//   that string however you need to!
					// For example, that string could be:
					//   Printed to the output window
					//   Saved in an array of strings
					//   Saved in a list of strings
					//   Used to instantiate classes with data from a file
					//   ... and more!
				}
			}
			catch (Exception)
			{
				Console.WriteLine("A file reading error occurred!");
			}
			finally
			{
				// Step 3: Close the stream
				if (reader != null)
				{
					reader.Close();
				}
            }


			// -------------------------------------------------------------------------
			// File Writing ------------------------------------------------------------
			// -------------------------------------------------------------------------
			// Step 1: Open the stream, pass in filename
			//  - If file does not exist, a new file with that name in that directory
			//    will be created.
			//  - Overwrites the data by default
			//    FYI: Only with this constructor. Other constructors have different params
			//    that allow for other read/write modes, like append.

			try
			{
				writer = new StreamWriter(filenameToWrite);

				// Step 2: Write to the file!
				//  - Use the Write or WriteLine method for all data written to the file
				//    since all data in a text file are strings!
				writer.WriteLine("First line");
				writer.WriteLine("Second line");
				writer.WriteLine("Third line");
				writer.WriteLine("Fourth line of text here.");
				writer.Write("This text");
				writer.Write("will be");
				writer.Write("smooshed");
				writer.Write("because of Write");
				writer.Write("vs. WriteLine");
			}
			catch (Exception)
			{
				Console.WriteLine("A file writing error occurred!");
			}
			finally
			{
				// Step 3: Close the stream.  
				//  - Contents are not written to the file until the stream is closed.
				if (writer != null)
				{
                    writer.Close();
                }
            }
			#endregion


			#region File Reading and Writing with Text Splitting
			// This part of the demo reads and writes to the SAME file. 
			// Reads from and writes to: allData.txt

			Console.WriteLine(
				"\n* *******************************************************\n" +
				"This part of the demo splits data read from a file," +
				" and adds more data to that same file.\n");

			// -------------------------------------------------------------------------
			// File Reading ------------------------------------------------------------
			// -------------------------------------------------------------------------
			try
			{
				// Step 1: Open the stream, pass in filename
				reader = new StreamReader(filenameToReadAndWrite);

				// Step 2:  Read all data from the file, line by line
				//  - lineOfTextFromFile is already declared above as a string.
				//    We can reuse the variable here!
				string lineOfTextFromFile = null;
				while ((lineOfTextFromFile = reader.ReadLine()) != null)
				{
					// Print to the console for testing that we read the
					//   file properly.
					Console.WriteLine("The entire line is: " + lineOfTextFromFile);

					// After being read in, the line of text can be split into
					//   a string array with the Split method.
					// Pass the delimiter (a single character) into the Split method
					string[] splitData = lineOfTextFromFile.Split('|');

					// Now that the data has been read into a string array, you can use
					//   that string array however you need to!
					// For example, that string array's data could be:
					//   Printed to the output window
					//   Saved in 2 or more arrays of strings
					//   Saved in 2 or more lists of strings
					//   Used to instantiate classes with data from a file
					//      For instance, index 0 (the enemy's name) could be passed into
					//      a constructor to initialize a name field. And index 1 could
					//      be passed into the constructor to initialize a health field, 
					//      etc.
					//   ... and more!

					// I'm going to keep it simple and break the data into 3 lists of strings
					// Each index from the split string will be added to its corresponding list.
					enemyNames.Add(splitData[0]);
					enemyHealths.Add(splitData[1]);
					enemyWeapons.Add(splitData[2]);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("A file reading error occurred!");
			}
			finally
			{
				// Step 3: Close the stream
				if (reader != null)
				{
					reader.Close();
				}
            }


			// -------------------------------------------------------------------------
			// Main: Print out the lists -----------------------------------------------
			// -------------------------------------------------------------------------
			// Use a for loop to print out the lists
			Console.WriteLine("\nHere is all the data read from the file: ");
			for (int i = 0; i < enemyNames.Count; i++)
			{
				string outputToConsole = String.Format(
					"   Enemy #{0}: {1} with {2} health attacks with their {3}.",
					i + 1, 
					enemyNames[i], 
					enemyHealths[i], 
					enemyWeapons[i]);
                Console.WriteLine(outputToConsole);
			}


			// -------------------------------------------------------------------------
			// File Writing ------------------------------------------------------------
			// -------------------------------------------------------------------------
			try
			{
				// Step 1: Open the stream, pass in filename
				writer = new StreamWriter(filenameToReadAndWrite);

				// Step 2: Write to the file!
				// Since I'm writing to the same file, and everything will be overwritten
				//   I need to write out everything I've read and saved and then add data 
				//   (if desired).
				// If writing delimited data, must add the delimeter in the string.

				// Write everything from the 3 lists
				for (int i = 0; i < enemyNames.Count; i++)
				{
					string outputToFile = String.Format(
						"{0}|{1}|{2}",
						enemyNames[i],
						enemyHealths[i],
						enemyWeapons[i]);
					writer.WriteLine(outputToFile);
				}

				// Add a few more enemies:
				writer.WriteLine("Bob the HR Rep|1|Paperweight");
				writer.WriteLine("T-Rex|500|Teeth");
				writer.WriteLine("Dash|37|Paws of Steel");
			}
			catch (Exception)
			{
                Console.WriteLine("A file writing error occurred!");
            }
			finally
			{
				// Step 3: Close the stream.  
				// Contents are not written to the file until the stream is closed!
				if (writer != null)
				{
					writer.Close();
				}
            }


			// -------------------------------------------------------------------------
			// File Reading (ONCE MORE) ------------------------------------------------
			// -------------------------------------------------------------------------

			try
			{

				// Instantiate reader
				reader = new StreamReader(filenameToReadAndWrite);

				// Clear the lists so we start with fresh read-in data
				enemyNames.Clear();
				enemyHealths.Clear();
				enemyWeapons.Clear();

				// Read in all data, adding to the appropriate list.
				string lineOfTextFromFile = null;
				while ((lineOfTextFromFile = reader.ReadLine()) != null)
				{
					string[] splitData = lineOfTextFromFile.Split('|');
					enemyNames.Add(splitData[0]);
					enemyHealths.Add(splitData[1]);
					enemyWeapons.Add(splitData[2]);
				}
			}
			catch (Exception)
			{
                Console.WriteLine("A file reading error occurred!");
            }
			finally
			{
				// Close the stream
				if (reader != null)
				{
					reader.Close();
				}
			}


			// -------------------------------------------------------------------------
			// Main: Print out the lists (AGAIN) ---------------------------------------
			// -------------------------------------------------------------------------
			// Use a for loop to print out the lists
			Console.WriteLine("\nHere is all the data read from the file AFTER adding new data: ");
			for (int i = 0; i < enemyNames.Count; i++)
			{
				string outputToConsole = String.Format(
					"   Enemy #{0}: {1} with {2} health attacks with their {3}.",
					i + 1,
					enemyNames[i],
					enemyHealths[i],
					enemyWeapons[i]);
				Console.WriteLine(outputToConsole);
			}
			#endregion


			#region File Reset (so demo works as expected)
			// Re-write the original data to the file, just so the demo acts as expected.
			// YOU WOULD NOT TYPICALLY DO THIS unless a program should start with the same
			//   data every time it runs. 
			writer = new StreamWriter(filenameToReadAndWrite);

			// Write the 3 original enemies:
			writer.WriteLine("Gollum|50|Precious");
			writer.WriteLine("Fluffy the Terrible|125|Rubber Mallet of Doom");
			writer.WriteLine("Gnoll|15|Mace");

			// Close the stream.  
			writer.Close();

			#endregion
		}
	}
}
