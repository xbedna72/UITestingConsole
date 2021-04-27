using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReportManager
{
	public class HtmlCreater
	{
		string filePath;
		private ReportModel actualReport = null;
		string fileContent = "";

		public HtmlCreater(ReportModel _report, string _path)
		{
			actualReport = _report;
			filePath = GenerateResultFile(_path);
			fileContent = StartOfHtml();
			foreach (TestMethodModel model in actualReport.methods)
			{
				foreach (TestCaseModel testCase in model.cases)
				{
					try
					{
						fileContent += Test(testCase);
					}
					catch (Exception e)
					{
						fileContent += $"<div><p>Unable to generate test case informations<p></div>\n";
					}
				}
			}
			fileContent += EndOfHtml();
			File.WriteAllText(filePath, fileContent);
		}

		private string GenerateResultFile(string _path)
		{
			string _fileName = "Report-";
			string date = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
			_fileName = $"{_fileName}{date}.html";
			this.filePath = $"{_path}\\{_fileName}";
			return this.filePath;
		}

		private void ParseContent()
		{
			fileContent += StartOfHtml();
		}

		private string StartOfHtml()
		{
			return $"<!DOCTYPE html>\n<html>" +
			$"<head>\n<link type=\"text/css\">\n" +
			$"<meta content=\"charset =UTF-8\">\n" +
			$"<style>\n" +
			$"img {{ width: 1000px;}}" +
			$"#errorP{{ color: red; font-size: 20px; }}" +
			$"</style>\n" +
			$"</head>\n<body>\n" +
			$"<div id=\"header\"><h3>{actualReport.testProjectName}</h3>\n<h4>{actualReport.testProjectPath}</h4></div>";
		}

		private string Test(TestCaseModel _model)
		{
			string result = _model.result == true ? "SUCCESS" : "FAILED";
			string test = $"<div>\n<h3>\nTest case: {_model.num}\n" +
			$"<p>\nFind {_model.element.TagName}</p>\n" +
			$"<p\n>Result {result}</p>\n";
			if (_model.window.screenshot != null)
			{
				try
				{
					byte[] image = RenderButton(_model);
					if (image != null)
					{
						test += $"<p>\nScreenshot</p>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(image)}\">\n";
					}
				}
				catch
				{
					test += $"<p>\nScreenshot</p><p id=\"errorP\">Unable to show image of element.</p>\n";
				}
			}
			test += $"</h3>\n</div>\n";
			return test;
		}

		private string EndOfHtml()
		{
			return $"</body>\n</html>\n";
		}

		private byte[] RenderButton(TestCaseModel _model)
		{
			System.Drawing.Image image;
			using (MemoryStream ms = new MemoryStream(_model.window.screenshot))
			{
				image = System.Drawing.Image.FromStream(ms);
			}
			System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 3);
			using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image))
			{
				g.DrawRectangle(pen, _model.element.Location.X, _model.element.Location.Y, _model.element.Size.Width, _model.element.Size.Height);
			}
			pen.Dispose();
			byte[] imageBytes;
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				imageBytes = ms.ToArray();
			}
			return imageBytes;
		}

		//Get Size of window does not work. This mathod is prepared for future updates.
		private string CutOutMainWindow(byte[] _image, TestCaseModel _model)
		{
			System.Drawing.Rectangle rec = new System.Drawing.Rectangle(_model.window.Position, _model.window.Size);
			System.Drawing.Bitmap src;
			using (var ms = new MemoryStream(_image))
			{
				src = new System.Drawing.Bitmap(ms);
			}

			System.Drawing.Bitmap target = new System.Drawing.Bitmap(_model.window.Size.Width ,_model.window.Size.Height);
			using(System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(target)){
				g.DrawImage(src, new System.Drawing.Rectangle(0, 0, target.Width, target.Height), rec, System.Drawing.GraphicsUnit.Pixel);
			}
			src.Dispose();
			byte[] imageResult;
			using(var ms = new MemoryStream()){
				target.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				imageResult = ms.ToArray();
			}
			target.Dispose();
			return Convert.ToBase64String(imageResult);
		}
	}
}
