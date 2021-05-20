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
        private static int count = 0;
        private RichTextBox myRichTxt;
        public Crawler(String startUri,RichTextBox richTextBox)
        {
            urls.Add(startUri, 4);
            //4表示首页url，未被爬行过
            //3表示首页url，已被爬行过
            //2表示从首页爬取到的url，未被爬行过
            //1表示从首页爬取到的url，已被爬行过
            new Thread(Crawl).Start();
            myRichTxt = richTextBox;
        }
        private void Crawl()
        {
            Console.WriteLine("开始爬行");
            int sleepCount = 0;
            while (true)
            {
                String current = null;
                lock (this)
                {
                    foreach (String url in urls.Keys)
                    {
                        if ((int)urls[url] == 4 || (int)urls[url] == 2)//查找未被爬过的url
                        {
                            current = url;
                            break;
                        }
                    }
                    if (current != null) urls[current] = (int)urls[current] - 1;//表示该url被爬取过
                }
                if (current == null) {
                    //如果暂时不存在未被爬行的url，则主线程睡眠，等待爬行线程爬取url并解析，更新url集合
                    Thread.Sleep(2000);
                    sleepCount++;
                    continue;
                }
                if (sleepCount >= 5)
                {
                    MessageBox.Show($"已经很长时间无法发现新的url以继续爬行了，程序结束，爬行url总数{count}.");
                    return;
                }
                if ( count > 10) break;
                Console.WriteLine("开始爬行" + current + "页面:");
                new Thread(()=>Download_and_Parse(current)).Start();//开启新线程爬行，多线程并行爬取多个url
            }
            Console.WriteLine("结束");
            MessageBox.Show("全部结束");
        }
        private void Download_and_Parse(String current)
        {
             Download(current);
            Thread.Sleep(1000);
        }
        private async void Download(String url)
        {
            String html = "";
            try
            {
                WebClient webclient = new WebClient();
                webclient.Encoding = Encoding.UTF8;
                try
                {
                    Task<String> task = Task.Run(() => webclient.DownloadString(url));
                    html = await task;
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
            }catch(Exception e)
            {
                return;
            }
            if (this.myRichTxt.InvokeRequired)
            {
                myRichTxt.Invoke(new Action(
                    () => {
                        myRichTxt.AppendText($"\n==========================\nCount={count}\n当前Uri:{url}\n");
                        myRichTxt.AppendText(html);
                    }));
            }
            bool flag;
                flag = (int)urls[url] == 3;//只爬取主页面的url，即仅把爬行过主页面中解析到的url加入url集合
            if (flag) Parse(html, url);

            lock (this) { count++; }//同步锁更新，防止count多线程更新出错
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
                lock (this)
                {
                    if (urls[strRef] == null) urls[strRef] = 2;
                }

            }
        }
    }
}
