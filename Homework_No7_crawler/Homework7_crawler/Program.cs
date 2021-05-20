using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7_crawler
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
    public class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private RichTextBox myRichTxt;
        public Crawler(String startUri,RichTextBox richTextBox)
        {
            urls.Add(startUri, 2);
            new Thread(Crawl).Start();
            myRichTxt = richTextBox;
        }
        private void Crawl()
        {
            Console.WriteLine("开始爬行");
            int subUri = 0;
            while (true)
            {
                String current = null;
                foreach(String url in urls.Keys){
                    if ((int)urls[url] == 0) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("开始爬行" + current + "页面:");

                String html = Download(current);
                if (this.myRichTxt.InvokeRequired)
                {
                    myRichTxt.Invoke(new Action(
                        () =>{
                            myRichTxt.AppendText($"\n==========================\nCount={count}\n当前Uri:{current}\n");
                            myRichTxt.AppendText(html);
                        }));
                }
                if ((int)urls[current] == 2) Parse(html, current);
                else subUri++;

                urls[current] = 0;
                count++;
            }
            Console.WriteLine("结束");
            MessageBox.Show("全部结束");
        }
        private String Download(String url)
        {
            try
            {
                WebClient webclient = new WebClient();
                webclient.Encoding = Encoding.UTF8;
                String html = "";
                try
                {
                    html = webclient.DownloadString(url);
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
                return html;
            }catch(Exception e)
            {
                return "";
            }
        }
        public void Parse(String html,String current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            Console.WriteLine(matches.Count);
            Uri baseUri = new Uri(current);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;


                if (strRef.Contains(".."))
                {
                    strRef = new Uri(baseUri, strRef).AbsoluteUri;
                }
                /*if (!strRef.Contains("http")) {
                    strRef = "http:" + strRef;
                }*/
                if (urls[strRef] == null) urls[strRef] = 1;

            }
        }
    }
}
