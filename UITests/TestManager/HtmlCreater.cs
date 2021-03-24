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

		public HtmlCreater(ReportModel _report, string _path) {
			actualReport = _report;
			filePath = $"C:\\Users\\MayBee\\Desktop\\Results";
			filePath = GenerateResultFile();
			fileContent = StartOfHtml();
			foreach(TestMethodModel model in actualReport.methods){
				foreach(TestCaseModel testCase in model.cases){
					try{
						fileContent += Test(testCase);
					}catch(Exception e){
						fileContent += $"<div><p>Unable to generate test case informations<p></div>\n";
					}
				}
			}
			fileContent += EndOfHtml();
			File.WriteAllText(filePath, fileContent);
		}

		private string GenerateResultFile()
		{
			string _fileName = "Report-";
			string date = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
			_fileName = $"{_fileName}{date}.html";
			this.filePath = $"{this.filePath}\\{_fileName}";
			return this.filePath;
		}

		private void ParseContent() {
			fileContent += StartOfHtml();
		}

		private string StartOfHtml() {
			return $"<!DOCTYPE html>\n<html>" +
			$"<head>\n<link type=\"text/css\">\n" +
			$"<meta content=\"charset =UTF-8\">\n" +
			$"<style>\n" +
			$"img {{ width: 1000px;}}" +
			$"</style>\n"+
			$"</head>\n<body>\n";
		}

		private string Test(TestCaseModel _model){
			string result = _model.result == true ? "SUCCESS" : "FAILED";
			string test = $"<div>\n<h3>\nTest case: {_model.num}\n" +
			$"<p>\nFind {_model.element.TagName}</p>\n" +
			$"<p\n>Result {result}</p>\n";
			if(_model.screenshot != null){
				test += $"<p>\nScreenshot</p>\n<img src=\"data:image/gif;base64,{RenderButton(_model.screenshot, _model.element.Location, _model.element.Size)}\">\n";
			}
			test += $"</h3>\n</div>\n";
			return test;
		}

		private string EndOfHtml(){
			return $"</body>\n</html>\n";
		}

		private string RenderButton(byte[] _screenShot, System.Drawing.Point _point, System.Drawing.Size _size){
			System.Drawing.Image image;
			using(MemoryStream ms = new MemoryStream(_screenShot)){
				image = System.Drawing.Image.FromStream(ms);
			}
			System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 3);
			using(System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image)){
				g.DrawRectangle(pen, _point.X, _point.Y, _size.Width, _size.Height);
			}
			pen.Dispose();
			byte[] imageBytes;
			using(MemoryStream ms = new MemoryStream()){
				image.Save(ms, image.RawFormat);
				imageBytes = ms.ToArray();
			}
			return Convert.ToBase64String(imageBytes);
		}
	}
}
