﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingInterfaceTextApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer; 
        public FileLogger(string path)
        {
            writer = File.CreateText(path); //파일을 만드는 작업
            writer.AutoFlush = true; //자동으로 데이터를 쓰는것 = AutoFlush

        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog {DateTime.Now}\t >>>>>> {message}");
        }
    }
}
