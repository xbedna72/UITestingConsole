using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReportManager
{
	public class HtmlCreater
	{
		static string filePath;
		protected static ReportModel actualReport = null;
		static string content = "";

		public HtmlCreater(ReportModel _report, string _path)
		{
			actualReport = _report;
			filePath = GenerateResultFile(_path);
			ParseIntoHtml();
		}

		private void ParseIntoHtml()
		{
			content += StartOfHtml();
			Write();
			foreach (TestMethodModel method in actualReport.methods)
			{
				content += Method(method);
				Write();
				foreach (TestCaseModel testCase in method.cases)
				{
					try
					{
						content += Test(testCase);
					}
					catch (Exception e)
					{
						content += $"<div><p>Unable to generate test case informations<p></div>\n";
					}
					Write();
				}
			}
			content += EndOfHtml();
			Write();
		}

		private void Write()
		{
			try
			{
				using (StreamWriter file = new StreamWriter(filePath, append: true))
				{
					file.Write(content);
				}
			}
			catch
			{

			}
			content = "";
		}

		private string GenerateResultFile(string _path)
		{
			string _fileName = "Report-";
			string date = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
			_fileName = $"{_fileName}{date}.html";
			filePath = $"{_path}\\{_fileName}";
			return filePath;
		}

		private static string StartOfHtml()
		{
			return $"<!DOCTYPE html>\n<html>" +
			$"<head>\n<link type=\"text/css\">\n" +
			$"<meta content=\"charset =UTF-8\">\n" +
			$"<style>\n" +
			$"body div {{margin-left: auto; margin-right: auto; width: max-content;}}" +
			$"#element img {{ width: 100px; }}\n" +
			$"#window img {{ width: 400px; }}\n" +
			$"#method img {{ width: 600px; }}\n" +
			$"#errorP{{ color: red; font-size: 20px; }}\n" +
			$"</style>\n" +
			$"</head>\n<body>\n" +
			$"<div id=\"header\"><h3>{actualReport.testProjectName}</h3>\n<h4>{actualReport.testProjectPath}</h4></div>";
		}

		private static string Test(TestCaseModel _model)
		{
			string result = string.Empty;
			string test = string.Empty;

			if (_model.action == Enums.Actions.Note)
			{
				test = $"<div>\n<h4>\nNote: {_model.info}\n</h4>";
			}
			else
			{
				result = _model.result == true ? "SUCCESS" : "FAILED";
				test = $"<div>\n<h4>\nTest case: #{_model.num}\n</h4>" +
				$"<p>\nFind {_model.element.TagName}</p>\n" +
				$"<p\n>Result {result}</p>\n";
				if (_model.element.elementScreenshot != null)
				{
					try
					{
						test += $"<div id=\"window\">\n<p>View of Window:</p>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(_model.element.windowScreenshot)}\">\n</div>";
						test += $"<h4>\nBefore click on button:</h4><div id=\"element\">\n<p>Element</p>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(_model.element.elementScreenshot)}\">\n</div>";
					}
					catch (Exception e)
					{
						test += $"<p id=\"errorP\">Test case view not available.</p>\n";
					}
				}
			}
			test += $"\n</div>\n";
			return test;
		}

		private string Method(TestMethodModel model){
			string method = "";
			method += $"<div>\n<h4>\nTest method: #{model.num}\n</h4>";
			if(model.startScreenshot != null){
				try{
					method += $"<div id=\"method\"><h4>\nStart screenshot before method launche.</h4>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(model.startScreenshot)}\">\n</div>";
				}catch{
					method += $"<p id=\"errorP\">Method start view not available.</p>\n";
				}
			}

			if (model.endScreenshot != null)
			{
				try
				{
					method += $"<div id=\"method\"><h4>\nEnd screenshot after method launche.</h4>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(model.endScreenshot)}\">\n</div>\n";
				}
				catch
				{
					method += $"<p id=\"errorP\">Method start view not available.</p>\n";
				}
			}

			method += "</div>\n";

			return method;
		}

		private static string EndOfHtml()
		{
			return $"</body>\n</html>\n";
		}

		//private static byte[] RenderButton(TestCaseModel _model)
		//{
		//	System.Drawing.Image image;
		//	using (MemoryStream ms = new MemoryStream(_model.element.screenshot))
		//	{
		//		image = System.Drawing.Image.FromStream(ms);
		//	}
		//	System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 3);
		//	using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image))
		//	{
		//		g.DrawRectangle(pen, _model.element.Location.X, _model.element.Location.Y, _model.element.Size.Width, _model.element.Size.Height);
		//	}
		//	pen.Dispose();
		//	byte[] imageBytes;
		//	using (MemoryStream ms = new MemoryStream())
		//	{
		//		image.Save(ms, image.RawFormat);
		//		image.Save("C:\\Tools", System.Drawing.Imaging.ImageFormat.Jpeg);
		//		imageBytes = ms.ToArray();
		//	}
		//	return imageBytes;
		//}

		//Get Size of window does not work. This mathod is prepared for future updates.
		//private string CutOutMainWindow(byte[] _image, TestCaseModel _model)
		//{
		//	System.Drawing.Rectangle rec = new System.Drawing.Rectangle(_model.window.Position, _model.window.Size);
		//	System.Drawing.Bitmap src;
		//	using (var ms = new MemoryStream(_image))
		//	{
		//		src = new System.Drawing.Bitmap(ms);
		//	}

		//	System.Drawing.Bitmap target = new System.Drawing.Bitmap(_model.window.Size.Width ,_model.window.Size.Height);
		//	using(System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(target)){
		//		g.DrawImage(src, new System.Drawing.Rectangle(0, 0, target.Width, target.Height), rec, System.Drawing.GraphicsUnit.Pixel);
		//	}
		//	src.Dispose();
		//	byte[] imageResult;
		//	using(var ms = new MemoryStream()){
		//		target.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
		//		imageResult = ms.ToArray();
		//	}
		//	target.Dispose();
		//	return Convert.ToBase64String(imageResult);
		//}
	}
}
