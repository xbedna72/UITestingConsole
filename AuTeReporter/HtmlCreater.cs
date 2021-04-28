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

		public HtmlCreater(ReportModel _report, string _path)
		{
			actualReport = _report;
			filePath = GenerateResultFile(_path);
			ParseIntoHtml();
		}

		private static void ParseIntoHtml(){
			var content = new BlockingCollection<string>(50);

			Task.Run(() =>
			{
				string i = "";
				while (!content.IsCompleted)
				{
					try
					{
						i = content.Take();
						using (StreamWriter file = new StreamWriter(@"C:\Tools\logg.txt", append: true))
						{
							file.Write(i);
						}
					}
					catch (InvalidOperationException)
					{
						break;
					}
					Thread.SpinWait(100000);
				}
			});

			Task.Run(() => {
				string test;
				content.Add(StartOfHtml());
				foreach (TestMethodModel model in actualReport.methods)
				{
					foreach (TestCaseModel testCase in model.cases)
					{
						try
						{
							test = Test(testCase);
							content.Add(test);
						}
						catch (Exception e)
						{
							content.Add($"<div><p>Unable to generate test case informations<p></div>\n");
						}
					}
				}
				content.Add(EndOfHtml());
			});
		}

		private static string GenerateResultFile(string _path)
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
			$"img {{ width: 1000px;}}" +
			$"#errorP{{ color: red; font-size: 20px; }}" +
			$"</style>\n" +
			$"</head>\n<body>\n" +
			$"<div id=\"header\"><h3>{actualReport.testProjectName}</h3>\n<h4>{actualReport.testProjectPath}</h4></div>";
		}

		private static string Test(TestCaseModel _model)
		{
			string result = string.Empty;
			string test = string.Empty;

			if (_model.action == Enums.Actions.Note){
				test = $"<div>\n<h3>\nTest case: {_model.num}\n" +
				$"<p>\nNote: {_model.info}</p>\n";
			}
			else{
				result = _model.result == true ? "SUCCESS" : "FAILED";
				test = $"<div>\n<h3>\nTest case: {_model.num}\n" +
				$"<p>\nFind {_model.element.TagName}</p>\n" +
				$"<p\n>Result {result}</p>\n";
				if (_model.element.screenshot != null)
				{
					test += Convert.ToBase64String(_model.element.screenshot);
					try
					{
						//byte[] image = RenderButton(_model);
						//if (image != null)
						//{
						//	test += $"<p>\nScreenshot</p>\n<img src=\"data:image/gif;base64,{Convert.ToBase64String(image)}\">\n";
						//}
					}
					catch
					{
						test += $"<p>\nScreenshot</p><p id=\"errorP\">Unable to show image of element.</p>\n";
					}
				}
			}
			test += $"</h3>\n</div>\n";
			return test;
		}

		private static string EndOfHtml()
		{
			return $"</body>\n</html>\n";
		}

		private static byte[] RenderButton(TestCaseModel _model)
		{
			System.Drawing.Image image;
			using (MemoryStream ms = new MemoryStream(_model.element.screenshot))
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
