﻿using System;
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

		public static void Main(string[] args)
		{
			consoleManager = ConsoleManager.Instance;
			consoleManager.InfoMessage("**********************************************************************\n" +
										"** AuTeR 2021 Automated Tester v1.0\n" +
										"** This tool was made as automated MSTest runner. The tool provides work with repository before test run.\n" +
										"** Author: Marie Bednřová\n" +
										"** Brno University of Technology - Faculty of Information Technology\n" +
										"** Year: 2021\n" +
										"**********************************************************************\n");
			//consoleManager.StartControl();

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

			consoleManager.ErrorMessage("No arguments passed.");
			consoleManager.End();
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
							if (args[i].Equals("/TestAdapterPath:"))
							{
								i++;
								if (args[i].Length > 0)
								{
									consoleManager.adapterPath = args[i];
									i++;
									if (args[i].Equals("/TestResultsDirectory:"))
									{
										i++;
										if (Directory.Exists(args[i].ToString()))
										{
											consoleManager.resultsDirestory = args[i].ToString();
											i++;
										}
										else
										{
											consoleManager.ErrorMessage("Input path to results directtory does not exists.");
											break;
										}
									}
									else
									{
										consoleManager.resultsDirestory = null;
									}

									if (args[i].Equals("/Executable:"))
									{
										i++;
										if (args[i].Length > 0)
										{
											consoleManager.executable = args[i];
											if (i + 1 < args.Count())
											{
												i++;
												if (args[i].Equals("-b", StringComparison.OrdinalIgnoreCase))
												{
													i++;
													if (args.Count() <= i && Regex.IsMatch(args[i], "[A-Z]:(\\\\(.+))+.sln$"))
													{
														consoleManager.slnPath = args[i];
														consoleManager.BuildFlag = true;
														i++;
													}
													else
													{
														consoleManager.ErrorMessage($"The path or name of solution project is wrong or missing.");
														break;
													}
												}

												if (args[i].Equals("-s", StringComparison.OrdinalIgnoreCase))
												{
													i++;
													if (args.Count() <= i && Regex.IsMatch(args[i], @".+\\emails\.xml$"))
													{
														consoleManager.emailsPath = args[i];
														consoleManager.SendFlag = true;
													}
													else
													{
														consoleManager.ErrorMessage($"The path to file with emails is wrong or missing.");
														break;
													}
												}
												
												if(args.Count() > i + 1)
												{
													consoleManager.ErrorMessage($"Unknown parameters on position: {i}");
													break;
												}
											}
											return false;
										}
										else
										{
											consoleManager.ErrorMessage("Wrong format of Executable path. Absolute path with name of .exe file.");
											break;
										}
									}
									else
									{
										consoleManager.ErrorMessage("Parameter Application in bad format or missing.");
									}
								}
								else
								{
									consoleManager.ErrorMessage("Wrong format of Application name. Absolute path with name of .exe file.");
								}
							}
							else
							{
								consoleManager.ErrorMessage("Parameter TestAdapterPath is missing.");
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
							Console.WriteLine("Help text.");
							return true;
						}
					}
				}
				catch (Exception e)
				{
					e.ToString();
					consoleManager.ErrorMessage("Wrong formate of input arguments. Run with \"?\" or \"-h\" for help.");
				}
			}
			consoleManager.ErrorInput = true;
			return false;
		}
	}
}
