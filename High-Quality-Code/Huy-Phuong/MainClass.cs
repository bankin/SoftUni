using System;
using System.Globalization;
using System.Linq;

namespace TheatresManagement
{
    public class MainClass
    {
        protected static void Main()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == null)
                {
                    return;
                }

                if (commandLine != string.Empty)
                {
                    string command = commandLine.Split('(')[0];
                    string[] commandArgs = commandLine.Split(new[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    string commandResult;
                    
                    try
                    {
                        switch (command)
                        {
                            case "AddTheatre":
                                commandResult = ExecuteCommand.AddTheatre(commandArgs[1].Trim());
                                break;
                            case "PrintAllTheatres":
                                commandResult = ExecuteCommand.PrintAllTheatres();
                                break;
                            case "AddPerformance":                                
                                string[] commandArgsTrim = commandArgs.Skip(1).Select(p => p.Trim()).ToArray();

                                string theatreName = commandArgsTrim[0];
                                string performanceTitle = commandArgsTrim[1];
                                DateTime startDateTime = DateTime.ParseExact(commandArgsTrim[2], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
                                TimeSpan duration = TimeSpan.Parse(commandArgsTrim[3]);
                                decimal price = decimal.Parse(commandArgsTrim[4], NumberStyles.Float);

                                commandResult = ExecuteCommand.AddPerformance(theatreName, performanceTitle, startDateTime, duration, price);
                                break;
                            case "PrintAllPerformances":
                                commandResult = ExecuteCommand.PrintAllPerformances();
                                break;
                            case "PrintPerformances":                                
                                string theatre = commandArgs[1].Trim();
                                commandResult = ExecuteCommand.PrintPerformances(theatre);
                                break;
                            default:
                                commandResult = "Invalid command!";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        commandResult = "Error: " + ex.Message;
                    }

                    Console.WriteLine(commandResult);
                }
            }
        }
    }   
}
