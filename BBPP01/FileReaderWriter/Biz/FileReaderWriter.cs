using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter.Biz
{
    public class FileReaderWriter
    {
        private Stream _file = null;
        private FileReaderWriterMode _mode = FileReaderWriterMode.NotDef;

        #region Constructor

        public FileReaderWriter()
        {
            _file = null;
            _mode = FileReaderWriterMode.NotDef;
        }

        public FileReaderWriter(string path, FileReaderWriterMode mode)
        {
            OpenFile(path, mode);
        }

        ~FileReaderWriter()
        {
            if (IsOpen())
            {
                _file.Flush();
                _file.Close();
            }
        }

        #endregion

        #region Opener

        public bool OpenFile(string path, FileReaderWriterMode mode)
        {
            try
            {

                switch (mode)
                {
                    case FileReaderWriterMode.Read:
                        return OpenFileRead(path);

                    case FileReaderWriterMode.Write:
                        return OpenFileWrite(path);

                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                _file = null;
                _mode = FileReaderWriterMode.NotDef;
                return false;
            }
        }

        private bool OpenFileRead(string path)
        {
            try
            {
                _file = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Read);
                _mode = FileReaderWriterMode.Read;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                _file = null;
                _mode = FileReaderWriterMode.NotDef;
                return false;
            }
            return true;
        }

        private bool OpenFileWrite(string path)
        {
            try
            {
                _file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                _mode = FileReaderWriterMode.Write;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                _file = null;
                _mode = FileReaderWriterMode.NotDef;
                return false;
            }
            return true;
        }

        #endregion

        #region Reader

        public async Task<string> Read()
        {
            using(var reader = new StreamReader(_file))
            {
                try
                {
                    return await reader.ReadToEndAsync();
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                    _file = null;
                    _mode = FileReaderWriterMode.NotDef;
                    return null;
                }
            }
        }
        #endregion

        #region Writer

        public async Task<bool> Write(string line)
        {
            using (var writer = new StreamWriter(_file))
            {
                try
                {
                    await writer.WriteLineAsync(line);
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                    _file = null;
                    _mode = FileReaderWriterMode.NotDef;
                    return false;
                }
                return true;
            }
        }
        #endregion

        #region Utils

        public bool IsOpen()
        {
            return _file != null;
        }

        public FileReaderWriterMode GetMode()
        {
            return _mode;
        }

        #endregion
    }

    public enum FileReaderWriterMode
    {
        NotDef = -1,
        Read = 0,
        Write = 1
    }
}
