using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	class Program
	{
		public static ConsoleManager consoleManager = null;
		public static string info = "";
		private static string calculator = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

		public static void Main(string[] args)
		{
			consoleManager = ConsoleManager.Instance;
			consoleManager.InfoMessage("**********************************************************************\n" +
									"** AuTeR v1.0\n" +
									"** Author: Marie Bednarova\n" +
									"** Brno University of Technology - Faculty of Information Technology\n" +
									"** Year: 2021\n" +
									"**********************************************************************\n");
			// consoleManager.StartControl();

			if (args.Count() > 0)
			{
				var helpFlag = ParseInputArguments(args);

				if (consoleManager.ErrorInput)
				{
					consoleManager.ErrorEnd("End...");
				}
				else if (helpFlag)
				{
					consoleManager.End();
				}

				try
				{
					consoleManager.Process();
					consoleManager.End();
				}
				catch (Exception e)
				{
					consoleManager.ErrorEnd(e.ToString());
				}
			}
			consoleManager.ErrorEnd("No arguments passed. Invalid input.");
		}

		//try
		//{
		//	Loop();  
		//}
		//catch (Exception e)
		//{
		//	consoleManager.ErrorMessage(e.ToString());
		//}

		//Loop method for interacting using, planning to finishe in next release
		//static void Loop()
		//{
		//	while (true)
		//	{
		//		Console.Write(">> ");
		//		consoleManager.input = Console.ReadLine().Split(' ');
		//		int r = consoleManager.Decision();
		//		switch (r)
		//		{
		//			case 0:
		//				return;
		//			case 1:
		//				Console.WriteLine("Run");
		//				consoleManager.Run = true;
		//				break;
		//			case 2:
		//				consoleManager.NewSettingFile();
		//				break;
		//			case 3:
		//				if (!consoleManager.SetSettingFile())
		//				{
		//					consoleManager.ErrorMessage("Unable to set setting file.");
		//				}
		//				break;
		//			case 4:
		//				consoleManager.ShowAllSettingFiles();
		//				break;
		//			default:
		//				consoleManager.ErrorMessage("Unknown command or wrong format of argument.");
		//				break;
		//		}
		//		if (consoleManager.Run)
		//		{
		//			consoleManager.Process();
		//		}
		//	}
		//}

		static bool ParseInputArguments(string[] args)
		{
			for (int i = 0; i < args.Count(); i++)
			{
				try
				{
					if (args[i].Equals("/TestSolutionPath:"))
					{
						i++;
						if (Regex.IsMatch(args[i], "[A-Z]:(\\\\(.+))+.sln$"))
						{
							consoleManager.testName = args[i];
							i++;
							if (!(i < args.Count()))
							{
								consoleManager.ErrorMessage("Parameter TestAdapterPath is missing.");
								break;
							}
							if (args[i].Equals("/TestAdapterPath:"))
							{
								i++;
								if ((i < args.Count()) == false)
								{
									consoleManager.ErrorMessage("Not defined path of test adapter.");
									break;
								}

								if (Directory.Exists(args[i].ToString()))
								{
									consoleManager.adapterPath = args[i];
									i++;
									if ((i < args.Count()) == false)
									{
										consoleManager.ErrorMessage("Not defined executable file. Wrong input.");
										break;
									}

									if (args[i].Equals("/TestResultsDirectory:"))
									{
										i++;
										if ((i < args.Count()) == false)
										{
											consoleManager.ErrorMessage("Not defined path of test results directory.");
											break;
										}

										if (Directory.Exists(args[i].ToString()))
										{
											consoleManager.resultsDirestory = args[i].ToString();
											i++;
										}
										else
										{
											consoleManager.ErrorMessage("Input path to results directory not exists.");
											break;
										}
									}

									if (args[i].Equals("/Executable:"))
									{
										consoleManager.resultsDirestory = null;
										i++;
										if (i < args.Count() && (Regex.IsMatch(args[i], "[A-Z]:(\\\\(.+))+.exe$") || args[i].Equals(calculator)))
										{
											consoleManager.executable = args[i];
											if (i + 1 < args.Count())
											{
												i++;
												if (args[i].Equals("-p", StringComparison.OrdinalIgnoreCase))
												{
													i++;
													if (args.Count() >= i)
													{
														if (Directory.Exists(args[i].ToString()))
														{
															consoleManager.slnPath = args[i];
															consoleManager.PullFlag = true;
															i++;
															if (!(i < args.Count()))
															{
																return false;
															}
														}
													}
													consoleManager.ErrorMessage($"The path into a folder with project solution file is wrong or empty.");
													break;
												}

												//if (args[i].Equals("-s", StringComparison.OrdinalIgnoreCase))
												//{
												//	i++;
												//	if (args.Count() <= i && Regex.IsMatch(args[i], @".+\\emails\.xml$"))
												//	{
												//		consoleManager.emailsPath = args[i];
												//		consoleManager.SendFlag = true;
												//	}
												//	else
												//	{
												//		consoleManager.ErrorMessage($"The path to file with emails is wrong or missing.");
												//		break;
												//	}
												//}

												consoleManager.ErrorMessage($"Unknown input.");
												break;
											}
											return false;
										}
										else
										{
											consoleManager.ErrorMessage("Wrong format or empty string of Executable path.");
											break;
										}
									}
									else
									{
										consoleManager.ErrorMessage("Unknown parameter after /TestAdapterPath: .");
									}
								}
								else
								{
									consoleManager.ErrorMessage("The path to test adapter does not exists.");
								}
							}
							else
							{
								consoleManager.ErrorMessage("Unknown parameter after /TestSolutionPath: .");
							}
						}
						else
						{
							consoleManager.ErrorMessage("Wrong format of Test solution absolute path. File type .sln.");
						}
						break;
					}
					//else if (args[i + 1].Equals("/SettingFile:"))
					//{
					//	consoleManager.actualSettingFile = args[i + 2];
					//	return true;
					//}
					else if (args[i].Equals("?", StringComparison.OrdinalIgnoreCase) || args[i].Equals("-h", StringComparison.OrdinalIgnoreCase) || args[i].Equals("help", StringComparison.OrdinalIgnoreCase))
					{
						if (args.Count() == 1)
						{
							Console.WriteLine("AuTeR - Automated Test Runner (Version: 1.0)\n\n" +
							"Usage:\n" +
							"AuTeR.lnk [-h] /TestSolutionPath: [value] /TestAdapterPath: [value] [/TestResultsDirectory: [value]] /Executable: [value] [-p [value]]\n" +
							"\nPositional parameters:\n" +
							"\t\t/TestSolutionPath:	Absolute path to a project with a tests. The file name should contain \".sln\".\n" +
							"\t\t /TestAdapterPath:	Absolute path to a folder where file of the type \".dll\" will be generated after build process, which will be placed in \"\\Debug\" folder.\n" +
							"\t\t      /Executable:	Absolute path to an executable file of testing project, the name should include suffix \".exe\".\n" +
							"Optional arguments and parameters:\n" +
							"\t\t/TestResultsDirectory:	Absolute path to folder is where results should be saved after test run.\n" +
							"						-p:	If a pull of an executable project is needed, put in absolute path\n" +
							"							to folder, where project solution file is placed.\n" +
							"					 -h, ?:	To show this message.\n");
							return true;
						}
					}
					else
					{
						consoleManager.ErrorMessage("Unknown command. Invalid input. Run with \"?\" or \"-h\" for help message.");
						break;
					}
				}
				catch (Exception e)
				{
					e.ToString();
					consoleManager.ErrorMessage("Wrong formate of input arguments. Run with \"?\" or \"-h\" for help message.");
				}
			}
			consoleManager.ErrorInput = true;
			return false;
		}
	}
}
