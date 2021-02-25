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

		public static void Main(string[] args)
		{
			consoleManager = ConsoleManager.Instance;
			consoleManager.InfoMessage("Starting console.");
			consoleManager.StartControl();

			if (args.Count() > 0)
			{
				var helpFlag = ParseInputArguments(args);

				if (!helpFlag && consoleManager.ErrorInput)
				{
					consoleManager.ErrorEnd("End...");
				}
				else if (consoleManager.Run)
				{
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
				else if (helpFlag)
				{
					consoleManager.End();
				}
			}

			try
			{
				Loop();
			}
			catch (Exception e)
			{
				consoleManager.ErrorMessage(e.Message.ToString());
			}

			consoleManager.End();
		}

		static void Loop()
		{
			while (true)
			{
				Console.Write(">> ");
				consoleManager.input = Console.ReadLine().Split(' ');
				int r = consoleManager.Decision();
				switch (r)
				{
					case 0:
						return;
					case 1:
						Console.WriteLine("Run");
						consoleManager.Run = true;
						break;
					case 2:
						consoleManager.NewSettingFile();
						break;
					case 3:
						if (!consoleManager.SetSettingFile())
						{
							consoleManager.ErrorMessage("Unable to set setting file.");
						}
						break;
					case 4:
						consoleManager.ShowAllSettingFiles();
						break;
					default:
						consoleManager.ErrorMessage("Unknown command or wrong format of argument.");
						break;
				}
				if (consoleManager.Run)
				{
					consoleManager.Process();
				}
			}
		}

		static bool ParseInputArguments(string[] args)
		{
			for (int i = 0; i < args.Count(); i++)
			{
				if (args[i].Equals("-a", StringComparison.OrdinalIgnoreCase))
				{
					consoleManager.Run = true;
					i++;
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
										if (args[i].Equals("/AppName:"))
										{
											i++;
											if (Regex.IsMatch(args[i], "[A-Z]:(\\\\(.+))+.exe$"))
											{
												consoleManager.appName = args[i];
												if (i + 1 < args.Count())
												{
													i++;
													if (args[i].Equals("-b", StringComparison.OrdinalIgnoreCase))
													{
														i++;
														if (Regex.IsMatch(args[i], "[A-Z]:(\\\\(.+))+.sln$"))
														{
															consoleManager.slnPath = args[i];
															consoleManager.BuildFlag = true;
															return true;
														}
														else
														{
															consoleManager.ErrorMessage($"The path or name of solution is wrong or missing.");
															break;
														}
													}
													consoleManager.ErrorMessage($"Unknown parameters on position: {i}");
													break;
												}
												return true;
											}
											else
											{
												consoleManager.ErrorMessage("Wrong format of Application name. Absolute path with name of .exe file.");
												break;
											}
										}
									}
									else
									{
										consoleManager.ErrorMessage("Wrong format of Application name. Absolute path with name of .exe file.");
									}
								}
							}
							else
							{
								consoleManager.ErrorMessage("Wrong format of Test solution absolute path. File type .sln.");
								break;
							}

							consoleManager.ErrorMessage("Undefined application name.");
							break;
						}
						else if (args[i + 1].Equals("/SettingFile:"))
						{
							consoleManager.actualSettingFile = args[i + 2];
							return true;
						}
						consoleManager.ErrorMessage("Undefined input parameter.");
						break;
					}
					catch (Exception e)
					{
						e.ToString();
						consoleManager.ErrorMessage("Wrong formate of input arguments. Run with \"?\" or \"-h\" for help.");
						break;
					}
				}
				else if (args[i].Equals("?", StringComparison.OrdinalIgnoreCase) || args[i].Equals("-h", StringComparison.OrdinalIgnoreCase))
				{
					if (args.Count() == 1)
					{
						Console.WriteLine("Help text.");
						return true;
					}
					break;
				}
				else
				{
					consoleManager.ErrorInput = true;
					return false;
				}
			}
			consoleManager.ErrorInput = true;
			return false;
		}
	}
}
